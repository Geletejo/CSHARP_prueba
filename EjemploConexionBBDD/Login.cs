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

            MySqlCommand comando = new MySqlCommand("" +
                "SELECT * FROM usuarios WHERE" +
                " usuario = '' OR 1=1; -- " + textBox1.Text +
                "' AND pass = '" + textBox2.Text +
                "' ;", conexion);

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
            }
        }
    }
}
