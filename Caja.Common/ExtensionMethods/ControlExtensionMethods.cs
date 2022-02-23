using System.ComponentModel;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace System
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class ControlExtensionMethods
    {
        /// <summary>
        /// Only calls to invoke if requires. Executes the action like the standard Invoke method
        /// </summary>
        /// <param name="ctrl">this</param>
        /// <param name="action">The action to perform</param>
        public static void InvokeFast(this Control ctrl, Action action)
        {
            if (ctrl == null)
            {
                action();
                return;
            }

            if (ctrl.IsDisposed || ctrl.Disposing)
                return;

            if (ctrl.InvokeRequired)
            {
                if (ctrl.IsDisposed || ctrl.Disposing)
                    return;

                while (!ctrl.IsHandleCreated)
                {
                    if (ctrl.IsDisposed || ctrl.Disposing)
                        return;

                    Thread.Sleep(50);
                }

                if (ctrl.IsDisposed || ctrl.Disposing)
                    return;
                try
                {
                    ctrl.Invoke((MethodInvoker)delegate
                    {
                        if (ctrl.IsDisposed || ctrl.Disposing)
                            return;
                        action();
                    }
                        );
                }
                catch (InvalidOperationException ex)
                {
                    // Si es: Invoke or BeginInvoke cannot be called on a control until the window handle has been created. que siga
                    if (!ex.Message.ContainsIgnoreCase("window handle"))
                        throw;
                }


            }
            else
            {
                action();
            }
        }


        public static void SetImage(this TreeNode node, string imageKey)
        {
            node.SelectedImageKey = imageKey;
            node.ImageKey = imageKey;
        }
        
        public static void DoubleBuffered(this Control dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, setting, null);
        }
    }
}
