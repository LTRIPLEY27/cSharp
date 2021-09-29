using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasComunicacion
{
    public partial class FormRectangulo : Form
    {
        public FormRectangulo()
        {
            InitializeComponent();
        }

        private void FormRectangulo_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            ClsRectangulo rectangle = new ClsRectangulo(Convert.ToInt32(txtAltura.Text), Convert.ToInt32(txtBase.Text));

            lblResponse.Text = rectangle.toString();
        }
    }
}
