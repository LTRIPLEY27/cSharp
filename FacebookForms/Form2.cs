using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookForms
{
    public partial class Form2 : Form
    {
        public Form2(string pInfo)
        {
            InitializeComponent();

            lblPrincipio.Text = pInfo;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
