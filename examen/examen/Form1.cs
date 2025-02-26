using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxMes.Items.Add("ENERO");
            comboBoxMes.Items.Add("FEBRERO");
            comboBoxMes.Items.Add("MARZO");
            comboBoxMes.Items.Add("ABRIL");
            comboBoxMes.Items.Add("MAYO");
            comboBoxMes.Items.Add("JUNIO");
            comboBoxMes.Items.Add("JULIO");
            comboBoxMes.Items.Add("AGOSTO");
            comboBoxMes.Items.Add("SEPTIEMBRE");
            comboBoxMes.Items.Add("OCTUBRE");
            comboBoxMes.Items.Add("NOVIEMBRE");
            comboBoxMes.Items.Add("DICIEMBRE");
            //aqui de clare los meses para el comboboxdel mes 


            comboBoxDias.Items.Add("01");
            comboBoxDias.Items.Add("02");
            comboBoxDias.Items.Add("03");
            comboBoxDias.Items.Add("04");
            comboBoxDias.Items.Add("05");
            comboBoxDias.Items.Add("06");
            comboBoxDias.Items.Add("07");
            comboBoxDias.Items.Add("08");
            comboBoxDias.Items.Add("09");
            comboBoxDias.Items.Add("10");
            comboBoxDias.Items.Add("11");
            comboBoxDias.Items.Add("12");
            comboBoxDias.Items.Add("13");
            comboBoxDias.Items.Add("14");
            comboBoxDias.Items.Add("15");
            comboBoxDias.Items.Add("16");
            comboBoxDias.Items.Add("17");
            comboBoxDias.Items.Add("18");
            comboBoxDias.Items.Add("19");
            comboBoxDias.Items.Add("20");
            comboBoxDias.Items.Add("21");
            comboBoxDias.Items.Add("22");
            comboBoxDias.Items.Add("23");
            comboBoxDias.Items.Add("24");
            comboBoxDias.Items.Add("25");
            comboBoxDias.Items.Add("26");
            comboBoxDias.Items.Add("27");
            comboBoxDias.Items.Add("28");
            comboBoxDias.Items.Add("29");
            comboBoxDias.Items.Add("30");
            comboBoxDias.Items.Add("31");
            // aqui de clare el comboboxdias para que el usuario no mas ponga el dia 
        }

        private void comboBoxsig_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonOPTENER_Click(object sender, EventArgs e)
        {
            if (comboBoxDias.SelectedItem == null || comboBoxMes.SelectedIndex == -1)//en la condicion del if primero vaciamos comboboxdias
            {
                MessageBox.Show("Seleccione un día y un mes.");
                return;
            }

            // Convertir valores de los ComboBox
            int dia = int.Parse(comboBoxDias.SelectedItem.ToString());// aqui de clare una variable con int dia para comboboxdias 
            int mes = comboBoxMes.SelectedIndex + 1; // Convertir el comboboxmes en int mes para que escoja

            string signo = "";

            if ((mes == 3 && dia >= 21) || (mes == 4 && dia <= 19))
                signo = "Aries";
            else if ((mes == 4 && dia >= 20) || (mes == 5 && dia <= 20))
                signo = "Tauro";
            else if ((mes == 5 && dia >= 21) || (mes == 6 && dia <= 20))
                signo = "Géminis";
            else if ((mes == 6 && dia >= 21) || (mes == 7 && dia <= 22))
                signo = "Cáncer";
            else if ((mes == 7 && dia >= 23) || (mes == 8 && dia <= 22))
                signo = "Leo";
            else if ((mes == 8 && dia >= 23) || (mes == 9 && dia <= 22))
                signo = "Virgo";
            else if ((mes == 9 && dia >= 23) || (mes == 10 && dia <= 22))
                signo = "Libra";
            else if ((mes == 10 && dia >= 23) || (mes == 11 && dia <= 21))
                signo = "Escorpio";
            else if ((mes == 11 && dia >= 22) || (mes == 12 && dia <= 21))
                signo = "Sagitario";
            else if ((mes == 12 && dia >= 22) || (mes == 1 && dia <= 19))
                signo = "Capricornio";
            else if ((mes == 1 && dia >= 20) || (mes == 2 && dia <= 18))
                signo = "Acuario";
            else if ((mes == 2 && dia >= 19) || (mes == 3 && dia <= 20))
                signo = "Piscis"; // aqui de clare los meses y dias que debe ser los sodiacos con lo que puso en las condiciones 
            else
                signo = "checa bien la fecha";// esto lo puse porsi algo sale mal 

            // Mostrar resultado en el TextBox
            textBoxZodi.Text = "Tu signo zodiacal es: " + signo;

        }

        private void textBoxZodi_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
