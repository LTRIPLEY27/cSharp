using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mensaje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola", "Mi mensaje");
            DialogResult r = MessageBox.Show("Probamos botones", "Diferentes botones", MessageBoxButtons.AbortRetryIgnore); // LO INSERTO EN EL PARENTESIS SON DOS ARGUMENTOS SEPARADOS POR LA COMA

            if(r == DialogResult.Retry)
            {
                lblMensaje.Text = "Intentar";
            } if(r == DialogResult.Abort)
            {
                lblMensaje.Text = "abortar";
            } if(r == DialogResult.Ignore)
            {
                lblMensaje.Text = "Ignorar";
            }
        }
    }
}
