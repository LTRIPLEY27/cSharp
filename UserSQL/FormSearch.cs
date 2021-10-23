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
    public partial class FormSearch : Form
    {
        Conect conecta;
        public FormSearch()
        {
            InitializeComponent();
            conecta = new Conect();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void btnSearch_Click(object sender, EventArgs e)
        {
            string response = cmbOptions.SelectedItem.ToString();
            string option = txtResponse.Text;

            conecta.Search(response, option, dgvSearch);
            //conecta.CargarDatos(dgvSearch);
        }

        public void dgvSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
