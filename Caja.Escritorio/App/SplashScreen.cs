using Caja.Escritorio;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System
{
    public static class SplashScreen
    {
        private static FrmLogin mSplash;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        internal static extern bool SetWindowText(IntPtr hWnd, string lpString);
        private readonly static object mLockActivated = new object();
        private static Semaphore mSemaphoreSplash = new Semaphore(0, 1);
        public static void Show(string title, Icon ico)
        {
            var semaphore = new Semaphore(0, 1);
            var t = Task.Factory.StartNew(
                () =>
                {
                    mSplash = new FrmLogin();
                    if (ico != null)
                        mSplash.Icon = ico;
                    var primerActivacion = true;
                    
                    mSplash.ShowSplashImage();

                    mSplash.Activated += (sender, args) =>
                    {
                        lock (mLockActivated)
                        {
                            if (!primerActivacion)
                                return;

                            primerActivacion = false;
                            mSemaphoreSplash.Release();
                        }
                    };
                    SetWindowText(mSplash.Handle, title);

                    var sema = semaphore;
                    ((Semaphore)sema).Release();
                    mSplash.ShowDialog();
                });

            semaphore.WaitOne();
            semaphore.Dispose();
            Thread.Sleep(100);
        }

        public static void HideWhenActivated(Form frm)
        {
            var splash = mSplash;
            if (splash != null)
            {
                frm.Activated += new EventHandler(frm_Activated);
            }
        }

        private static void frm_Activated(object sender, EventArgs e)
        {
            var frm = ((Form)sender);
            frm.Activated -= frm_Activated;
            frm.BringToFront();

            if (mSemaphoreSplash != null)
            {
                mSemaphoreSplash.WaitOne();
                mSemaphoreSplash.Dispose();
                mSemaphoreSplash = null;
            }

            frm.Activate();
            Hide();
        }

        public static void Hide()
        {
            var splash = mSplash;
            if (splash != null)
            {
                mSplash = null;

                while (splash.IsHandleCreated == false)
                {
                    Thread.Sleep(50);
                }

                //Thread.Sleep(50);

                splash.InvokeFast(() =>
                {
                    splash.Hide();

                    if (splash.BackgroundImage != null)
                        splash.BackgroundImage.Dispose();

                    splash.Dispose();
                });
            }
        }

        public static ValidateUserResult ValidateUser(string defaultUser, Action<ValidateUserResult> userValidator)
        {
            ValidateUserResult res = null;
            mSplash.InvokeFast(() =>
            {
                mSplash.txtUsuario.Text = "";
                Application.DoEvents();
                mSplash.panLogging.Show();
                Application.DoEvents();

                if (defaultUser.IsNullOrEmpty())
                    mSplash.txtUsuario.Focus();
                else
                    mSplash.txtPassword.Focus();

                mSplash.UserValidator = userValidator;
                res = mSplash.ValidationResult;
            }
                );

            mSplash.Sync.WaitOne();
            return mSplash.ValidationResult;
        }


        public sealed class ValidateUserResult
        {
            internal ValidateUserResult(string user, string pass)
            {
                User = user;
                Pass = pass;
            }

            public bool ValidUser { get; set; }
            public bool ValidPass { get; set; }

            public string User { get; set; }
            public string Pass { get; set; }

            public object OperatorObject { get; set; }

        }
    }



}