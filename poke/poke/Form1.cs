using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.IO;

namespace poke
{
    public partial class Form1 : Form
    {
        private MySqlConnection conexion;
        private int idActual = 1;
        private string idImagen = "001";

        public Form1()
        {
            InitializeComponent();
            ConectarBaseDatos();
            CargarPokemon(idActual);
        }

        private void ConectarBaseDatos()
        {
            string conexionString = "server=localhost; database=pokemon; user=root; password=;";
            conexion = new MySqlConnection(conexionString);
        }

        private void CargarPokemon(int id)
        {
            try
            {
                using (MySqlConnection conexionTemp = new MySqlConnection(conexion.ConnectionString))
                {
                    conexionTemp.Open();
                    string consulta = "SELECT * FROM regristros WHERE ID = @id"; // Tabla con el nombre incorrecto
                    using (MySqlCommand comando = new MySqlCommand(consulta, conexionTemp))
                    {
                        comando.Parameters.AddWithValue("@id", id);
                        using (MySqlDataReader lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                labelID.Text = lector["ID"].ToString();
                                labelNOM.Text = lector["NOMBRE"].ToString();
                                labelTIPO1.Text = lector["TIPO1"].ToString();
                                labelTIPO2.Text = lector["TIPO2"].ToString();
                                labelDES.Text = lector["DESCRIPCION"].ToString();

                                idImagen = idActual.ToString("D3");
                                string rutaImagen = Path.Combine(Application.StartupPath, "images", $"{idImagen}.png");

                                if (File.Exists(rutaImagen))
                                {
                                    CargarImagen(rutaImagen);
                                }
                                else
                                {
                                    string rutaDefault = Path.Combine(Application.StartupPath, "images", "default.png");
                                    if (File.Exists(rutaDefault))
                                    {
                                        CargarImagen(rutaDefault);
                                    }
                                    else
                                    {
                                        MessageBox.Show("No se encontró la imagen del Pokémon ni la imagen por defecto.");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("No hay más Pokémon en la base de datos.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el Pokémon: " + ex.Message);
            }
        }

        private void CargarImagen(string ruta)
        {
            try
            {
                using (FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read))
                {
                    pictureBox1.Image = Image.FromStream(fs);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la imagen: " + ex.Message);
            }
        }

        private void buttonSIG_Click(object sender, EventArgs e)
        {
            idActual++;
            CargarPokemon(idActual);
        }

        private void buttonANTE_Click(object sender, EventArgs e)
        {
            if (idActual > 1)
            {
                idActual--;
                CargarPokemon(idActual);
            }
            else
            {
                MessageBox.Show("Es el primer Pokémon.");
            }
        }
    }
}
