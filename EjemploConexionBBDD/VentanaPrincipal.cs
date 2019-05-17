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
            comboBox1.Items.Add("movies");
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
            if (comboBox1.Text == "movies")
            {
                String consultaPelis = "SELECT movies.id, movies.name, movies.year "
                                        + "from movies ORDER BY name";
                comboBox2.Items.Clear();
                MySqlConnection conectarPelis = new ConexionBBDD().conecta();
                MySqlCommand comando = new MySqlCommand(consultaPelis, conectarPelis);
                MySqlDataReader busqueda = comando.ExecuteReader();

                while (busqueda.Read())
                {
                    String id = busqueda.GetString("id");
                    String name = busqueda.GetString("name");
                    String year = busqueda.GetString("year");

                    comboBox2.Items.Add(id + "-" + name + " " + year + " ");

                }
                conectarPelis.Close();
            }
            
        }
    }



        //private void button2_Click(object sender, EventArgs e)
        //{
        //    datos.Clear();
        //    dataGridView1.DataSource = null;
        //    dataGridView1.Rows.Clear();

        //    String textoBuscador2 = textBox2.Text;

        //    MySqlConnection conexionInformacion = new ConexionBBDD().conecta();

        //    MySqlCommand comando =
        //        new MySqlCommand("SELECT actors.* from actors where actors.id = " + textoBuscador2
        //        , conexionInformacion);

        //    MySqlDataReader resultado = comando.ExecuteReader();


        //    datos.Load(resultado);
        //    dataGridView1.DataSource = datos;

        //    conexionInformacion.Close();
        //}


    }

