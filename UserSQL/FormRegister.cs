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
                btnView.Enabled = true;
                btnDelete.Enabled = true;
                btnEdited.Enabled = true;
                btnSearch.Enabled = true;
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            FormRegistrosResults registros = new FormRegistrosResults();

            registros.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            FormDelete delete = new FormDelete();

            delete.Show();
        }

        private void btnEdited_Click(object sender, EventArgs e)
        {
            FormEdited edited = new FormEdited();

            edited.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FormSearch search = new FormSearch();

            search.Show();
        }
    }
}
