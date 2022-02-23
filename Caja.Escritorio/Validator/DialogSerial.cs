using System;
using System.Windows.Forms;

namespace Caja.Escritorio.Validator
{
    public partial class DialogSerial : Form
    {
        public string Serial { get; set; }
        public DialogSerial()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            Serial = txtSerial.Text;
        }
    }
}
