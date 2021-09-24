using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaseLibros
{
    public partial class Form1 : Form
    {

        ClsLibros book; // DECLARACION DE LA CLASE EN EL AMBITO GLOBAL PARA PODER HACER USO DE LA MISMA POR TODOS LOS METODOS

        public Form1()
        {
            InitializeComponent();
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            book = new ClsLibros(txtTitle.Text, txtAuthor.Text, Convert.ToInt32(nuvExamples.Value));

            //btnVerRegistro.Enabled = true;

           // MessageBox.Show(book.toString());
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(book.toString());
        }
    }
}
