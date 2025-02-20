using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract5califi
{
    public partial class Form1: Form
    {
        double vresultado;//esta es la variable resultado
        public Form1()
        {
            InitializeComponent();
        }

        private void labelPro_Click(object sender, EventArgs e)
        {

        }

        private void buttonPro_Click(object sender, EventArgs e)
        {
            vresultado = (Convert.ToDouble(textBoxC1.Text) + Convert.ToDouble(textBoxC2.Text) + Convert.ToDouble(textBoxC3.Text)) / 3;
            // aqui es donde se ponen las calificaciones y luego se hase la operacion

            textBoxPro.Text = vresultado.ToString();
            if (vresultado >= 95)
            {
                labelEstatus.Text = "Exento";
            }
            else
            {
                if (vresultado >= 70)
                {
                    labelEstatus.Text = "Ordinario";
                }
                else
                {
                    if(vresultado >= 50)
                    {
                        labelEstatus.Text = "Extraordinario";
                    }
                    else
                    {
                        labelEstatus.Text = "Especial";
                    }
                }
            }

        }
    }
}
