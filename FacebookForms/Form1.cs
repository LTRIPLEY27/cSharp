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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            //CREAR LA INSTANCIA DE CLS FACEBOOK
            // LLAMAR A VER INFO()
            // PASAR LA INFORMACION A LA SEGUNDA FORMA

            ClsFacebook Micuenta = new ClsFacebook(txtName.Text, Convert.ToInt32(nupAge.Value), txtPassword.Text);

            string cad = Micuenta.VerInfo();

            Form2 MiForma = new Form2(cad);

            MiForma.ShowDialog();

        }
    }
}
