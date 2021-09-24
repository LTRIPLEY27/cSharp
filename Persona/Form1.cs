using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Persona
{
    public partial class Form1 : Form
    {
        ClsPerson person;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            person = new ClsPerson(txtName.Text, txtDni.Text, Convert.ToInt32(nudAge.Value));

            btnInformation.Enabled = true;
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            MessageBox.Show(person.toString());
        }
    }
}
