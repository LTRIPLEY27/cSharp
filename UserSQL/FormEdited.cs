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
    public partial class FormEdited : Form
    {
        Conect conected;
        public FormEdited()
        {
            InitializeComponent();
            conected = new Conect();
            conected.CargarDatos(dgvEdited);
        }

        private void btnEdited_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPassword.Text;
            string mail = txtMail.Text;

            conected.Actualiza(user, pass, mail);
            conected.CargarDatos(dgvEdited);
        }

        private void dgvEdited_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
