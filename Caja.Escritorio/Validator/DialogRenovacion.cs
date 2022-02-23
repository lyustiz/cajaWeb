using System;
using System.Windows.Forms;

namespace Caja.Escritorio.Validator
{
    public partial class DialogRenovacion : Form
    {
        public string Serial { get; set; }
        public DialogRenovacion()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            Serial = txtSerial.Text;
        }
    }
}
