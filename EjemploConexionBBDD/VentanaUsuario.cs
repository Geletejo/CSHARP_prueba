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
    public partial class VentanaUsuario : Form
    {

        private DataTable datos2 = new DataTable();

        public VentanaUsuario()
        {
            InitializeComponent();
            muestraString();
        }

        private void muestraString()
        {
            BuscarDNI.Text = VentanaPrincipal.seleccion;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string dni = BuscarDNI.Text.ToString();

            MySqlConnection conexionInformacion = new ConexionBBDD().conecta();

            MySqlCommand comando =
                new MySqlCommand("SELECT * FROM usuario WHERE DNI = '" +
                dni + "'",
                 conexionInformacion);

            MySqlDataReader busqueda = comando.ExecuteReader();
         


            if (busqueda.Read())
            {

            label4.Text = busqueda.GetString("Nombre");

            label5.Text = busqueda.GetString("Apellido");

            label6.Text = busqueda.GetString("email");

                conexionInformacion.Close();
            }
            try
            {
                pictureBox1.Image = Image.FromFile(@"D:\Angel Jimenez\fotos_usuarios\" + BuscarDNI.Text + ".jpg");
            
            }
            catch (Exception ex)
            {

            }
           
        }
    }
}
