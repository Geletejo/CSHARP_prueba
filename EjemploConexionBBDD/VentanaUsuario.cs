using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploConexionBBDD
{
    public partial class VentanaUsuario : Form
    {
        public VentanaUsuario()
        {
            InitializeComponent();
            muestraString();
        }

        private void muestraString()
        {
            labelNombre.Text = VentanaPrincipal.seleccion;
        }
        //VentanaPrincipal VentanaPrincipal = 
    }
}
