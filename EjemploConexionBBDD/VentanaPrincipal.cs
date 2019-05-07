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
        public VentanaPrincipal()
        {
            InitializeComponent();
            rellenaComboAutores();
            rellenaComboDirectores();
            rellenaComboPeliculas();
            rellenaComboGeneros();
        }

        //Codigo para que al cerrar este form, se cierre la app
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void rellenaComboAutores()
        {
            MySqlConnection conexion = new ConexionBBDD().conecta();
            MySqlCommand comando = new MySqlCommand("SELECT * FROM actors ORDER BY first_name", conexion);
            MySqlDataReader resultado = comando.ExecuteReader();
            while (resultado.Read())
            {
                //String id = resultado.GetString(0);
                String first_name = resultado.GetString("first_name");
                String last_name = resultado.GetString("last_name");
                String gender = resultado.GetString("gender");

                desplegableActores.Items.Add( first_name + "  " + last_name);
            }
            conexion.Close();
        }
        private void rellenaComboDirectores()
        {
            MySqlConnection conexion2 = new ConexionBBDD().conecta();
            MySqlCommand comando2 = new MySqlCommand("SELECT * FROM directors ORDER BY first_name", conexion2);
            MySqlDataReader resultado2 = comando2.ExecuteReader();
            while (resultado2.Read())
            {
                //String id = resultado2.GetString(0);
                String first_name = resultado2.GetString("first_name");
                String last_name = resultado2.GetString("last_name");

                desplegableDirectores.Items.Add( first_name + "  " + last_name);
            }

            conexion2.Close();

        }

        private void rellenaComboPeliculas()
        {
            MySqlConnection conexion3 = new ConexionBBDD().conecta();
            MySqlCommand comando3 = new MySqlCommand("SELECT * FROM movies ORDER BY year", conexion3);
            MySqlDataReader resultado3 = comando3.ExecuteReader();
            while (resultado3.Read())
            {
                //String id = resultado3.GetString(0);
                String name = resultado3.GetString("name");
                String year = resultado3.GetString("year");

                desplegablePeliculas.Items.Add(year + " -- " + name);
            }

            conexion3.Close();

        }

        private void rellenaComboGeneros()
        {
            MySqlConnection conexion4 = new ConexionBBDD().conecta();
            MySqlCommand comando4 = new MySqlCommand("SELECT DISTINCT * FROM movies_genres ORDER BY genre", conexion4);
            MySqlDataReader resultado4 = comando4.ExecuteReader();
            while (resultado4.Read())
            {
                //String id = resultado4.GetString(0);
                String genre = resultado4.GetString("genre");

                desplegableGeneros.Items.Add(genre);
            }

            conexion4.Close();

        }
    }
}
