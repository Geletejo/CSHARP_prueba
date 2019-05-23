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
    public partial class VentanaPrincipal : Form
    {

        private DataTable datos = new DataTable();
        public VentanaPrincipal()
        {
            InitializeComponent();
            desplegableComboBox1();

        }

        //Codigo para que al cerrar este form, se cierre la app
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void desplegableComboBox1() //Rellena el comboBox 
        {
            comboBox1.Items.Add("actors");
            comboBox1.Items.Add("directors");
            comboBox1.Items.Add("genres");
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //Esto para buscar Peli
        {
            datos.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            String textoBuscador = textBox1.Text;

            MySqlConnection conexionInformacion = new ConexionBBDD().conecta();

            MySqlCommand comando =
                new MySqlCommand("SELECT movies.* from movies where movies.name LIKE '%" + textoBuscador + "%'"
                , conexionInformacion);
           
            MySqlDataReader resultado = comando.ExecuteReader();

            datos.Load(resultado);

            dataGridView1.DataSource = datos;

            conexionInformacion.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "actors")
            {
                String consultaActor = "SELECT actors.first_name, actors.last_name, actors.id "
                                        + "from actors ORDER BY first_name";
                comboBox2.Items.Clear();
                MySqlConnection conectarActores = new ConexionBBDD().conecta();
                MySqlCommand comando = new MySqlCommand(consultaActor, conectarActores);
                MySqlDataReader busqueda = comando.ExecuteReader();

                while (busqueda.Read())
                {
                    String first_name = busqueda.GetString("first_name");
                    String last_name = busqueda.GetString("last_name");
                    String id = busqueda.GetString("id");

                    comboBox2.Items.Add(id + "-" + first_name + " " + last_name);

                }
                conectarActores.Close();
            }
            if (comboBox1.Text == "directors")
            {
                String consultaDirectores = "SELECT directors.first_name, directors.last_name, directors.id "
                                        + "from directors ORDER BY first_name";
                comboBox2.Items.Clear();
                MySqlConnection conectarDirectores = new ConexionBBDD().conecta();
                MySqlCommand comando = new MySqlCommand(consultaDirectores, conectarDirectores);
                MySqlDataReader busqueda = comando.ExecuteReader();

                while (busqueda.Read())
                {
                    String first_name = busqueda.GetString("first_name");
                    String last_name = busqueda.GetString("last_name");
                    String id = busqueda.GetString("id");

                    comboBox2.Items.Add(id + "-" + first_name + " " + last_name);

                }
                conectarDirectores.Close();
            }
            if (comboBox1.Text == "genres")
            {
                String consultaGeneros = "SELECT DISTINCT (genre)"
                                        + " FROM movies_genres ORDER BY genre";
                comboBox2.Items.Clear();
                MySqlConnection conectarGeneros = new ConexionBBDD().conecta();
                MySqlCommand comando = new MySqlCommand(consultaGeneros, conectarGeneros);
                MySqlDataReader busqueda = comando.ExecuteReader();

                while (busqueda.Read())
                {
                    String genre = busqueda.GetString("genre");

                    comboBox2.Items.Add(genre);

                }
                conectarGeneros.Close();
            }
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            datos.Clear();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            if (comboBox1.Text == "actors"){

                MySqlConnection conexionInformacion = new ConexionBBDD().conecta();

                MySqlCommand comando =
                    new MySqlCommand("SELECT name, alquiladas FROM movies " +
                    " WHERE id IN(SELECT movie_id FROM roles " +
                    " WHERE actor_id = '" + comboBox2.SelectedItem.ToString() + "');",
                     conexionInformacion);

                MySqlDataReader busqueda = comando.ExecuteReader();

                datos.Load(busqueda);

                dataGridView1.DataSource = datos;

                conexionInformacion.Close();
            }

            if (comboBox1.Text == "directors")
            {

                MySqlConnection conexionInformacion = new ConexionBBDD().conecta();

                MySqlCommand comando =
                    new MySqlCommand("SELECT name, alquiladas FROM movies " +
                    "WHERE id IN(SELECT movie_id FROM movies_directors " +
                    "WHERE director_id = '" + comboBox2.SelectedItem.ToString() + "');",
                     conexionInformacion);

                MySqlDataReader busqueda = comando.ExecuteReader();

                datos.Load(busqueda);

                dataGridView1.DataSource = datos;

                conexionInformacion.Close();
            }

            if (comboBox1.Text == "genres")
            {

                MySqlConnection conexionInformacion = new ConexionBBDD().conecta();

                MySqlCommand comando =
                    new MySqlCommand("SELECT name, alquiladas FROM movies " +
                    "WHERE id IN(SELECT movie_id FROM movies_genres " +
                    "WHERE genre = '" + comboBox2.SelectedItem.ToString() + "');",
                     conexionInformacion);

                MySqlDataReader busqueda = comando.ExecuteReader();

                datos.Load(busqueda);

                dataGridView1.DataSource = datos;

                conexionInformacion.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Visible = false; //Oculta esta ventana
            VentanaUsuario ventana = new VentanaUsuario();
            ventana.Visible = true;
        }
    }

}

