using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace act_4
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelusuario_Click(object sender, EventArgs e)
        {

        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            if(textUsuario.Text== "jesus"&& textPassword.Text == "jesus")
            {
                Form2 newfrom2 = new Form2();
                newfrom2.Show();
            }
            else
            {
                MessageBox.Show("El usuario o contraseña no coinciden", "error");
            }
        }
    }
}
