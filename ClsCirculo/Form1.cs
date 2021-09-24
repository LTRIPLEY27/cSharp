using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClsCirculo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbArea_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            // INSERSION DE LA CLASE CIRCLES EN EL EVENTO DEL BUTTON

            ClsCircles circle = new ClsCircles((int)Convert.ToDouble(txtRadio.Text)); 

            if(rbArea.Checked)
            {
                MessageBox.Show($"El area es: {Math.Round(circle.CalcularArea(), 2).ToString()} ");  // CLASE "MATH.ROUND" PARA ESPECIFICAR LA RESPUESTA EEN DECIMALES Y LA CANTIDAD DE LOS MISMOS
            } else
            {
                MessageBox.Show($"El perimetro es : {Math.Round(circle.CalcularPerimetro(), 2).ToString()}");
            }
        }
    }
}
