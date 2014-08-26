using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Presentacion
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        void cerrarSesion()
        {
            mnuAñadir.Enabled = false;
            this.Text = "Sistema Academia";
        }
        
        private void mnuIngresar_Click(object sender, EventArgs e)
        {
            cerrarSesion();
            Logging logging = new Logging();
            Persona persona = logging.mostrarLogging();
            if (persona != null)
            {
                this.Text += " - Bienvendio " + persona.Apellido + ", " + persona.Nombre;
                mnuAñadir.Enabled = true;
            }           
            logging = null;
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuAñadirUsuario_Click(object sender, EventArgs e)
        {
            ControladorPrincipal cp = new ControladorPrincipal();
            cp.agregarUsuario("Fede", "CALVI", "123412");
        }

        private void asdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Permisos p = new Permisos();
                p.Show();
        }
    }
}
