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
    public partial class Form1 : Form
    {

        ClsEmployees emple;
        public Form1() // 

        {
            InitializeComponent();
           

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            // LA INSTANCIA SE HA DE INSERTAR EN EL BOTON YA QUE ES EL QUE DISPARA EL EVENTO

            emple = new ClsEmployees(txtName.Text, txtLastname.Text, Convert.ToInt32(txtSueldo.Text), Convert.ToInt32(nupAge.Value), Convert.ToInt32(nupDays.Value)); //INICIALIZACION DEL OBJETO DE LA CLASE FACEBOOK

            // string cad = emple.toString();


            //Form2 empleadoInfo = new Form2(cad); // DECLARACION DEL OBJETO DE LA CLASE "FORMS" PARA INSERTAR LOS DATOS POR PARAMETROS Y QUE LA MISMA LA RECIBA // MEDIANTE EL CONSTRUCTOR DE ELLA

            Form2 empleadoInfo = new Form2(emple);  // ENVIANDO POR PARAMETROS LA INSTANCIA DE LA CLASE EMPLEADO.

            empleadoInfo.ShowDialog(); // ES IMPRESCINDIBLE UBICAR ESTE METODO LUEGO DE LA CREACION DEL OBJETO FORM
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Debe de ingresar datos para registrarse");
            this.Close();
        }
    }
}
