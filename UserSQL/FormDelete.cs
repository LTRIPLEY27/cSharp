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
    public partial class FormDelete : Form
    {
        Conect conecti;
        ClsUser user1;
        public FormDelete()
        {
            InitializeComponent();
            conecti = new Conect();
            conecti.CargarDatos(dgvEliminated);
   
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            string user = txtUser.Text;

                conecti.Elimina(user);
                conecti.CargarDatos(dgvEliminated);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvEliminated_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
