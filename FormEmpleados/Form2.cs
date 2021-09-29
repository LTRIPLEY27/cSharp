using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormEmpleados
{
    public partial class Form2 : Form
    {
        ClsEmployees emple;

        // CONSTRUCTOR DEL FORMS
        //public Form2(string var)  // EL FORM 2 RECIBE POR PARAMETROS EL "TOSTRING" DEL OBJETO, POR ELLO LO DEBEMOS DE INTRODUCIR EN EL CONSTRUCTOR

        public Form2(ClsEmployees emple)  /// ENVIANDO POR PARAMETROS UN OBJETO COMPLETO POR PARAMETROS
        { 
            InitializeComponent();

            lblTostring.Text = emple.toString();

        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
