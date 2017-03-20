using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_IntegracionContinua
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnLogin_Click(object sender, EventArgs e)
        {
            prueba l = new prueba();         
            if (l.Login(txtUser.Text, txtContra.Text))
            {
                MessageBox.Show("Login Correcto...!!!");
            }else
            {
                MessageBox.Show("Login incorrecto...!!!");
            }
        }
    }    
}
