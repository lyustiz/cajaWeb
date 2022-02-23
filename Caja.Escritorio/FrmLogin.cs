using System;
using System.Drawing;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace Caja.Escritorio
{
    internal partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        readonly Version mVersion = new Version(Application.ProductVersion);

        internal readonly Semaphore Sync = new Semaphore(0, 1);

        public SplashScreen.ValidateUserResult ValidationResult { get; set; }
        public Action<SplashScreen.ValidateUserResult> UserValidator { get; set; }

        internal void ShowSplashImage()
        {
            lblVersion.Text = "v " + mVersion.ToString(3);

            Assembly assembly = Assembly.GetExecutingAssembly();
            object[] attributes = assembly.GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);

            if (attributes.Length > 0)
            {
                AssemblyDescriptionAttribute descriptionAttribute = (AssemblyDescriptionAttribute)attributes[0];
                lblFechaRelease.Text = $"Fecha Release : {descriptionAttribute.Description}";
            }
        }

        private void ValidateUser()
        {
            ValidationResult = new SplashScreen.ValidateUserResult(txtUsuario.Text, txtPassword.Text);
            UserValidator(ValidationResult);

            if (ValidationResult.ValidUser && ValidationResult.ValidPass)
            {
                OnUserValidated(ValidationResult);
                return;
            }

            if (!ValidationResult.ValidUser)
            {
                txtUsuario.SelectAll();
                txtUsuario.Focus();
            }
            else
            {
                if (!ValidationResult.ValidPass)
                {
                    txtPassword.Clear();
                    txtPassword.SelectAll();
                    txtPassword.Focus();
                }
            }
        }

        private void OnUserValidated(SplashScreen.ValidateUserResult res)
        {
            ValidationResult = res;
            panLogging.Hide();
            this.Cursor = Cursors.WaitCursor;
            this.Update();
            Sync.Release();

        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtPassword.Text.IsNullOrEmpty())
                {
                    txtPassword.SelectAll();
                    txtPassword.Focus();
                }
                else if (txtUsuario.Text.IsNullOrEmpty())
                {
                    txtUsuario.SelectAll();
                    txtUsuario.Focus();
                }
                else
                    ValidateUser();
            }
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtUsuario.Text.IsNullOrEmpty())
                {
                    txtUsuario.SelectAll();
                    txtUsuario.Focus();
                }
                else if (txtPassword.Text.IsNullOrEmpty())
                {
                    txtPassword.SelectAll();
                    txtPassword.Focus();
                }
                else
                    ValidateUser();
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (panLogging.Visible)
            {
                OnUserValidated(new SplashScreen.ValidateUserResult(string.Empty, string.Empty));
            }
            else
                e.Cancel = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
