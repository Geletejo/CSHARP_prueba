using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EjemploConexionBBDD
{
    public partial class Login : Form
    {
        int intentos = 0;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new ConexionBBDD().conecta();

            String texto1 = textBox1.Text;
            String texto2 = textBox2.Text;

            MySqlCommand comando = new MySqlCommand("" +
                "SELECT * FROM usuarios WHERE" +
                " usuario = '" + textBox1.Text +
                "' AND pass = '" + textBox2.Text +
                "' ;", conexion);

            if (texto1.Contains ("'") || texto2.Contains("'"))
            {
                MessageBox.Show("Usuario Y/O contraseña incorrecto(s)", "ERROR");
                intentos++;
            }
            else { 
            MySqlDataReader resultado = comando.ExecuteReader();

            if (resultado.Read())
            {
                this.Visible = false; //Oculta esta ventana
                VentanaPrincipal ventana = new VentanaPrincipal();
                ventana.Visible = true;
            }
            else
            {
                MessageBox.Show("Usuario Y/O contraseña incorrecto(s)", "ERROR");
                    intentos++;
                }
        }
            if(intentos >=3)
            {
                MessageBox.Show("Lo has intentado demasiadas veces , sientate, respira y vuelve a intentarlo", "RELÁJATE");
                this.Close();
            }
        }
    }
}
