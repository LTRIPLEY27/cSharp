using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserSQL
{
    public partial class FormRegister : Form
    {
        Conect conecting = new Conect();
        ClsUser userNew;
        //ClsBaseDT conect = new ClsBaseDT();
        public FormRegister()
        {
            InitializeComponent();
            conecting.CargarDatos(dgvData); // CARGA LA CONEXION EN EL ONLOAD CON EL OBJETO DE LA CLASE CONECT
            //conect.GetConection();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            userNew = new ClsUser(txtUser.Text, txtPassword.Text, txtMail.Text);


            if (conecting.VerificaRegistro(userNew) == true)
            {
                conecting.Insert(userNew);
                MessageBox.Show("USUARIO DADO DE ALTA CORRECTAMENTE");
                conecting.CargarDatos(dgvData);

            }
            else
            {
                MessageBox.Show("USUARIO REGISTRADO, INTENTE CON OTRO ");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void chbConditions_CheckedChanged(object sender, EventArgs e)
        {
            if(chbConditions.Checked)
            {
                btnRegister.Enabled = true;
           
            }
        }

      
    }
}
