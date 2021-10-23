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
    public partial class FormRegistrosResults : Form
    {
        Conect conect;

        public FormRegistrosResults()
        {
            InitializeComponent();
            conect = new Conect();
            conect.CargarDatos(dgvData1);
        }

        private void dgvData1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
