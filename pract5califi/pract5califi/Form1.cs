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
            if (vresultado >= 95)//aqui va aser el primer if para sacar si eres exento
            {
                labelEstatus.Text = "Exento";
            }
            else//si no se clumple ponemos otro if para poner los demas estatus
            {
                if (vresultado >= 70)//aqui esta el segungo if donde si sacas 70 tu estatus es otro 
                {
                    labelEstatus.Text = "Ordinario";
                }
                else
                {
                    if(vresultado >= 50)//este terser if es porsi no se cumplen los otros if se ejecuta este que si sacas 50 tu estatus es extraordinario
                    {
                        labelEstatus.Text = "Extraordinario";
                    }
                    else
                    {
                        labelEstatus.Text = "Especial";//aqui es el ultimo else que si no cumples con sierta calificacion tu estatus es de especial
                    }
                }
            }

        }
    }
}
