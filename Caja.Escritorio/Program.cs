using App.Common;
using Caja.Dominio;
using Caja.Escritorio.App;
using Caja.Escritorio.Validator;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Win32;
using System;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Windows.Forms;

namespace Caja.Escritorio
{
    static class Program
    {
        public class Validacion
        {
            private string entradaSerial;
            private string idMachine;
            private RegistryKey registro;
            private CajaServicesClient clientServices;
            private Machines machineValid;

            private void GenerarIdentificadorMaquina()
            {
                idMachine = FingerPrint.Value();
            }

            private void ObtenerInformacionRegistro()
            {
                registro = Registry.CurrentUser.CreateSubKey(@"Software\Sistemas y Ayudas");
            }

            private bool MaquinaEsRegistrada()
            {
                return registro.GetValue("IdMachine") == null ? false : true;
            }

            private bool MaquinaEsValida()
            {
                return machineValid == null ? false : true;
            }

            private bool ValidarActivacion()
            {
                DialogResult dr = new DialogResult();
                DialogSerial frmDiagloSerial = new DialogSerial();

                while (frmDiagloSerial.Serial.IsNullOrEmpty())
                {
                    dr = frmDiagloSerial.ShowDialog();

                    if (dr == DialogResult.OK)
                    {
                        if (frmDiagloSerial.Serial.IsNullOrEmpty())
                        {
                            MessageBox.Show("Debe ingresar un serial para continuar con la activación", "CAJA STUDIO 2020", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            entradaSerial = frmDiagloSerial.Serial;

                    }
                    else if (dr == DialogResult.Cancel)
                        return false;
                }

                var serialValid = clientServices.ValidarSerialAsync(entradaSerial).GetAwaiter().GetResult();

                if (serialValid == null)
                {
                    MessageBox.Show("SERIAL INVALIDO", "CAJA STUDIO 2020", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    if (serialValid.IdMachine.NotIsNullOrEmpty() && serialValid.IdMachine != idMachine)
                    {
                        MessageBox.Show("Este serial ya fue activado, debe usar uno diferente.", "CAJA STUDIO 2020", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return false;
                    }
                    else
                    {
                        //Si no existe el IdMachine, entonces debe solicitar la Key.
                        var valid = clientServices.ValidarMachineAndSerialAsync(idMachine, entradaSerial).GetAwaiter().GetResult();

                        if (valid == null)
                        {
                            //Si no existe el IdMachine y serial entonces los asocio.
                            var resActivacion = clientServices.AsigarSerialMaquinaAsync(idMachine, entradaSerial).GetAwaiter().GetResult();

                            if (resActivacion > 0)
                            {
                                //Se activo correctamente.
                                MessageBox.Show("CAJA STUDIO 2020 AHORA CUENTA CON UNA LICENCIA VÁLIDA.", "CAJA STUDIO 2020", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                machineValid = clientServices.ValidarIdMaquinaAsync(idMachine).GetAwaiter().GetResult();

                                registro.SetValue("IdMachine", Seguridad.EncriptaConnexion(machineValid.IdMachine));
                                registro.SetValue("GreenTemplate", Seguridad.EncriptaConnexion(machineValid.Perpetua ? "$2020.perpetua" : "$tienequerenovar"));
                                if (machineValid.Vigencia.HasValue)
                                    registro.SetValue("RomboStudio", Seguridad.EncriptaConnexion(machineValid.Vigencia.Value.ToString()));
                                else
                                    registro.SetValue("RomboStudio", Seguridad.EncriptaConnexion("sya"));

                                registro.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Este serial ya fue activado, debe usar uno diferente.", "CAJA STUDIO 2020", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return false;
                        }
                    }
                }

                return true;
            }

            private bool ValidarVigencia()
            {
                //Validar vigencias
                if (!machineValid.Perpetua)
                {
                    if (machineValid.Vigencia.HasValue && machineValid.Vigencia.Value < DateTime.Now)
                    {
                        DialogResult dr = new DialogResult();
                        DialogRenovacion frmDiagloSerial = new DialogRenovacion();

                        while (frmDiagloSerial.Serial.IsNullOrEmpty())
                        {
                            dr = frmDiagloSerial.ShowDialog();

                            if (dr == DialogResult.OK)
                            {
                                if (frmDiagloSerial.Serial.IsNullOrEmpty())
                                {
                                    MessageBox.Show("Debe ingresar un serial para continuar con la activación", "CAJA STUDIO 2020", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                    entradaSerial = frmDiagloSerial.Serial;

                            }
                            else if (dr == DialogResult.Cancel)
                                return false;
                        }

                        var serialValid = clientServices.ValidarSerialAsync(entradaSerial).GetAwaiter().GetResult();

                        if (serialValid == null)
                        {
                            MessageBox.Show("SERIAL INVALIDO", "CAJA STUDIO 2020", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        else
                        {
                            if (serialValid.IdMachine.NotIsNullOrEmpty() && serialValid.IdMachine != idMachine)
                            {
                                MessageBox.Show("Este serial ya fue activado, debe usar uno diferente.", "CAJA STUDIO 2020", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return false;
                            }
                            else
                            {
                                //Si no existe el IdMachine, entonces debe solicitar la Key.
                                var valid = clientServices.ValidarMachineAndSerialAsync(idMachine, entradaSerial).GetAwaiter().GetResult();

                                if (valid == null)
                                {
                                    //Si no existe el IdMachine y serial entonces los asocio.
                                    var resActivacion = clientServices.AsigarSerialMaquinaAsync(idMachine, entradaSerial).GetAwaiter().GetResult();

                                    if (resActivacion > 0)
                                    {
                                        //Se activo correctamente.
                                        MessageBox.Show("CAJA STUDIO 2020 AHORA CUENTA CON UNA LICENCIA VÁLIDA.", "CAJA STUDIO 2020", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        machineValid = clientServices.ValidarMachineAndSerialAsync(idMachine, entradaSerial).GetAwaiter().GetResult();

                                        registro.SetValue("IdMachine", Seguridad.EncriptaConnexion(machineValid.IdMachine));
                                        registro.SetValue("GreenTemplate", Seguridad.EncriptaConnexion(machineValid.Perpetua ? "$2020.perpetua" : "$tienequerenovar"));
                                        if (machineValid.Vigencia.HasValue)
                                            registro.SetValue("RomboStudio", Seguridad.EncriptaConnexion(machineValid.Vigencia.Value.ToString()));
                                        else
                                            registro.SetValue("RomboStudio", Seguridad.EncriptaConnexion("sya"));
                                              
                                        registro.Close();
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Este serial ya fue activado, debe usar uno diferente.", "CAJA STUDIO 2020", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return false;
                                }
                            }
                        }
                    }
                }

                registro.SetValue("IdMachine", Seguridad.EncriptaConnexion(machineValid.IdMachine));
                registro.SetValue("GreenTemplate", Seguridad.EncriptaConnexion(machineValid.Perpetua ? "$2020.perpetua" : "$tienequerenovar"));

                if (machineValid.Vigencia.HasValue)
                    registro.SetValue("RomboStudio", Seguridad.EncriptaConnexion(machineValid.Vigencia.Value.ToString()));
                else
                    registro.SetValue("RomboStudio", Seguridad.EncriptaConnexion("sya"));

                registro.Close();

                return true;
            }

            private bool ValidarVigenciaDesdeRegistro()
            {
                //Validar vigencias
                var perpetuidad = registro.GetValue("GreenTemplate");

                if (perpetuidad == null)
                {
                    MessageBox.Show("Se detecto que el registro de windows cambio para [CAJA STUDIO 2020] sin autorizacion del propietario.", "CAJA STUDIO 2020", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                {
                    var strPerpetuo = Seguridad.DesencriptaConexion(Convert.ToString(perpetuidad).ToString());

                    if (strPerpetuo == "$tienequerenovar")
                    {
                        var vigencia = registro.GetValue("RomboStudio");

                        if (vigencia == null)
                        {
                            MessageBox.Show("Se detecto que el registro de windows cambio para [CAJA STUDIO 2020] sin autorizacion del propietario.", "CAJA STUDIO 2020", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                        else
                        {
                            var strVigencia = Seguridad.DesencriptaConexion(Convert.ToString(vigencia).ToString());
                            if (strVigencia != "sya")
                            {
                                DateTime fechaValidez;
                                DateTime.TryParse(strVigencia, out fechaValidez);

                                if (fechaValidez < DateTime.Now)
                                {
                                    DialogResult dr = new DialogResult();
                                    DialogRenovacion frmDiagloSerial = new DialogRenovacion();

                                    while (frmDiagloSerial.Serial.IsNullOrEmpty())
                                    {
                                        dr = frmDiagloSerial.ShowDialog();

                                        if (dr == DialogResult.OK)
                                        {
                                            if (frmDiagloSerial.Serial.IsNullOrEmpty())
                                            {
                                                MessageBox.Show("Debe ingresar un serial para continuar con la activación", "CAJA STUDIO 2020", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            }
                                            else
                                                entradaSerial = frmDiagloSerial.Serial;

                                        }
                                        else if (dr == DialogResult.Cancel)
                                            return false;
                                    }

                                    var serialValid = clientServices.ValidarSerialAsync(entradaSerial).GetAwaiter().GetResult();

                                    if (serialValid == null)
                                    {
                                        MessageBox.Show("SERIAL INVALIDO", "CAJA STUDIO 2020", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return false;
                                    }
                                    else
                                    {
                                        if (serialValid.IdMachine.NotIsNullOrEmpty() && serialValid.IdMachine != idMachine)
                                        {
                                            MessageBox.Show("Este serial ya fue activado, debe usar uno diferente.", "CAJA STUDIO 2020", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            return false;
                                        }
                                        else
                                        {
                                            //Si no existe el IdMachine, entonces debe solicitar la Key.
                                            var valid = clientServices.ValidarMachineAndSerialAsync(idMachine, entradaSerial).GetAwaiter().GetResult();

                                            if (valid == null)
                                            {
                                                //Si no existe el IdMachine y serial entonces los asocio.
                                                var resActivacion = clientServices.AsigarSerialMaquinaAsync(idMachine, entradaSerial).GetAwaiter().GetResult();

                                                if (resActivacion > 0)
                                                {
                                                    //Se activo correctamente.
                                                    MessageBox.Show("CAJA STUDIO 2020 AHORA CUENTA CON UNA LICENCIA VÁLIDA.", "CAJA STUDIO 2020", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                    machineValid = clientServices.ValidarMachineAndSerialAsync(idMachine, entradaSerial).GetAwaiter().GetResult();

                                                    registro.SetValue("IdMachine", Seguridad.EncriptaConnexion(machineValid.IdMachine));
                                                    registro.SetValue("GreenTemplate", Seguridad.EncriptaConnexion(machineValid.Perpetua ? "$2020.perpetua" : "$tienequerenovar"));
                                                    if (machineValid.Vigencia.HasValue)
                                                        registro.SetValue("RomboStudio", Seguridad.EncriptaConnexion(machineValid.Vigencia.Value.ToString()));
                                                    else
                                                        registro.SetValue("RomboStudio", Seguridad.EncriptaConnexion("sya"));
                                                    
                                                    registro.Close();
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Este serial ya fue activado, debe usar uno diferente.", "CAJA STUDIO 2020", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                return false;
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    // Si esta proximo a vencerse muestro aviso.
                                    var tiempoRestante = fechaValidez.Subtract(DateTime.Now).TotalDays;

                                    if (tiempoRestante <= 3)
                                    {
                                        MessageBox.Show($"Su licencia se vence el próximo {fechaValidez.ToString("dd/MM/yyyy hh:mm")}, por favor contacte al propietario del software para una renovación.", "CAJA STUDIO 2020", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }
                        }

                    }
                }

                return true;
            }

            public bool ValidarSistema()
            {
                try
                {
                    ObtenerInformacionRegistro();
                    GenerarIdentificadorMaquina();

                    if (!MaquinaEsRegistrada())
                    {
                        clientServices = new CajaServicesClient(ConfigReader.ApiLicencia, new HttpClient());
                        machineValid = clientServices.ValidarIdMaquinaAsync(idMachine).GetAwaiter().GetResult();

                        if (!MaquinaEsValida())
                            return ValidarActivacion();
                        else
                            return ValidarVigencia();
                    }
                    else
                    {
                        clientServices = new CajaServicesClient(ConfigReader.ApiLicencia, new HttpClient());

                        return ValidarVigenciaDesdeRegistro();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error Controlado: {ex.Message} {Environment.NewLine}StackTrace: {ex.StackTrace}", "");
                    return false;
                }
            }

            public string ValidarCaducidad()
            {
                ObtenerInformacionRegistro();

                var vigencia = registro.GetValue("RomboStudio");

                var strVigencia = Seguridad.DesencriptaConexion(Convert.ToString(vigencia).ToString());
                if (strVigencia != "sya")
                {
                    DateTime fechaValidez;
                    DateTime.TryParse(strVigencia, out fechaValidez);

                    if (!(fechaValidez < DateTime.Now))
                    {
                        // Si esta proximo a vencerse muestro aviso.
                        var tiempoRestante = fechaValidez.Subtract(DateTime.Now).TotalDays;

                        if (tiempoRestante <= 3)
                        {
                            return $"Su licencia se vence el próximo {fechaValidez.ToString("dd/MM/yyyy hh:mm tt").ToUpper()}";
                        }
                    }
                }

                return string.Empty;
            }
        }

        public class Autenticacion
        {
            public Form Iniciar()
            {
                Form formStar;

                IUsuario usuario = null;
                SplashScreen.Show(Application.ProductName, null);

                while (usuario == null)                
                    usuario = ShowLoginForm();                

                SesionActiva.UsuarioActual = usuario;

                // Obtener todos los perfiles del usuario.
                if (SesionActiva.UsuarioActual != null)                
                    SesionActiva.UsuarioActualPerfiles = new DominioUsuario().FindPerfilesByUsuario(usuario.IdUsuario);
                                
                var frmlPrincipal = new FrmPrincipal();
                SplashScreen.HideWhenActivated(frmlPrincipal);
                formStar = frmlPrincipal;                   

                return formStar;
            }

            /// <summary>
            /// Carga el Formulario de loguin para ingresar al sistema
            /// </summary>
            /// <returns>El operador si fueron correcto los datos</returns>
            private static IUsuario ShowLoginForm()
            {
                var res = SplashScreen.ValidateUser("", (val) =>
                {
                    DominioUsuario mDominioUsuario = new DominioUsuario();

                    var ope = mDominioUsuario.Valid(val.User);

                    if (ope == null)
                    {
                        val.ValidUser = false;
                        MessageBox.Show("El usuario es inválido o no existe. Ingrese un usuario válido.", "CAJA STUDIO 2020", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    val.ValidUser = true;
                    {
                        if (ope.Clave != Seguridad.Encriptar(val.Pass))
                        {
                            val.ValidPass = false;
                            MessageBox.Show("La contraseña es inválida. Ingrese una contraseña válida", "CAJA STUDIO 2020", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (ope.Estado != 'H')
                        {
                            val.ValidUser = false;
                            MessageBox.Show("El usuario esta deshabilitado, contacte al administrador del sistema.", "CAJA STUDIO 2020", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    val.ValidPass = true;
                    val.OperatorObject = ope;

                    mDominioUsuario.UpdateLastLogin(ope.IdUsuario);
                }
                );

                return (IUsuario)res.OperatorObject;
            }
        }


        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [SecuritySafeCritical]
        [PermissionSet(SecurityAction.Assert, Unrestricted = true)]
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                SetProcessDPIAware();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                SingleInstanceManager manager = new SingleInstanceManager();
                manager.Run(args);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error Controlado: {ex.Message} {Environment.NewLine} StackTrace: {ex.StackTrace}", "");
            }
        }

        [DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        public class SingleInstanceManager : WindowsFormsApplicationBase
        {
            SingleInstanceApplication app;

            public SingleInstanceManager()
            {
                this.IsSingleInstance = true;
            }

            protected override bool OnStartup(StartupEventArgs e)
            {
                // First time app is launched
                app = new SingleInstanceApplication();
                app.Run();
                return false;
            }

            protected override void OnStartupNextInstance(StartupNextInstanceEventArgs eventArgs)
            {
                // Subsequent launches            
                base.OnStartupNextInstance(eventArgs);
                app.Activate();
            }
        }

        public class SingleInstanceApplication
        {
            protected Form mainForm;

            public void Activate()
            {
                // Reactivate application's main window            
                mainForm.Activate();
            }

            public void Run()
            {
                try
                {
                    Validacion objValidacion = new Validacion();

                    if (objValidacion.ValidarSistema())
                    {
                        mainForm = new Autenticacion().Iniciar();
                        Application.Run(mainForm);
                    }
                    else
                    {
                        MessageBox.Show($"Execute Run from SingleInstanceApplication ValidarSistema return false", "");
                        Environment.Exit(0);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error Controlado: {ex.Message} {Environment.NewLine} StackTrace: {ex.StackTrace}", "");
                }
            }
        }
    }
}
