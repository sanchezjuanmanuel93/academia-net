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


        Persona persona;


        private void Principal_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            mnuAlumnos.Visible = mnuProfesores.Visible 
                = mnuMaterias.Visible = mnuPermisos.Visible
                = mnuUsuarios.Visible= false;
        }

        void cerrarSesion()
        {
            this.Text = "Sistema Academia";
            persona = null;
        }
        
        private void mnuIngresar_Click(object sender, EventArgs e)
        {
            cerrarSesion();
            Logging logging = new Logging();
            persona = logging.mostrarLogging();
            if (persona != null)
            {
                this.Text += " - Bienvendio " + persona.Apellido + ", " + persona.Nombre;
                iniciaSesion();
            }           
            logging = null;
        }

        void iniciaSesion()
        {
            ControladorPermisos cP = new ControladorPermisos();
            foreach (ToolStripMenuItem item in mnuPrincipal.Items)
            {
                if (item.Text != "Inicio")
                {
                    item.Visible = cP.getPermisoUsuarioModulo(persona.Usuario, item.Text);                    
                }

            }
 
	
          
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

        private void mnuPermisos_Click(object sender, EventArgs e)
        {
            Permisos permisos = new Permisos();
            permisos.MdiParent = this;
            permisos.Show();
        }
    }
}
