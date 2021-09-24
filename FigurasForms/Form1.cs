using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasForms
{
    public partial class Form1 : Form
    {

        //ClsCirculo circle;
        ClsCuadrado cuadrade;
        ClsTriangulo triangle;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // cmbFiguras.Items.Add("Circulo");
            cmbFiguras.Items.Add("Cuadrado");
            cmbFiguras.Items.Add("Triangulo");
        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            string choice = cmbFiguras.SelectedItem.ToString();

            MessageBox.Show(choice);

            if(choice == "Cuadrado")
            {
                cuadrade = new ClsCuadrado(Convert.ToDouble(txtBase.Text), Convert.ToDouble(txtAltura.Text));
                MessageBox.Show(cuadrade.toString());
            } 
            if(choice == "Triangulo")
            {
                triangle = new ClsTriangulo(Convert.ToDouble(txtBase.Text), Convert.ToDouble(txtAltura.Text));
               // MessageBox.Show(cuadrade.toString());
                MessageBox.Show(triangle.toString());
            }
        }
    }
}
