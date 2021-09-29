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
    public partial class Form1 : Form
    {

        ClsCirculo circle;
        ClsRectangulo rectangle;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Text = "Figuras";
            cmbOpciones.Items.Add("Circulo"); // ADHESION DE LOS VALORES EN EL COMBOBOX
            cmbOpciones.Items.Add("Rectangulo");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            string choice = cmbOpciones.SelectedItem.ToString(); // IMPRESCINDIBLE CONVERTIR EL VALOR DEL COMBOBOX A TOSTRING

            if(choice == "Circulo")
            {
                //circle = new ClsCirculo();

                FormCirculo circulo = new FormCirculo(); // LLAMADO AL FORMCIRCULO 

                circulo.ShowDialog();
               // circulo.ShowDialog();

            } if(choice == "Rectangulo")
            {
                FormRectangulo rectangle = new       FormRectangulo(); // ANIDACION AL FORMRECTANGULO
               rectangle.ShowDialog();
            }



        }
    }
}
