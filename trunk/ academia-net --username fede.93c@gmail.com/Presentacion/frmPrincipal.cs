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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }


        Persona persona;


        private void Principal_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            cerrarSesion();
        }

        bool cerrarSesion()
        {

            if (persona!=null)
            {
                if (MessageBox.Show("Seguro que desea cerrar la sesion?", "Atencion!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    persona = null;
                    this.Text = "Sistema Academia";
                    foreach (Form form in this.MdiChildren)
                    {
                        form.Close();
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }

            
        mnuPersonas.Visible
        = mnuMaterias.Visible 
        = mnuPermisos.Visible
        = mnuUsuarios.Visible 
        = mnuComisiones.Visible
        = mnuEspecialidades.Visible 
        = mnuPlanes.Visible
        = mnuInscripciones.Visible = false;


                return true;


        }
        
        private void mnuIngresar_Click(object sender, EventArgs e)
        {
            if (cerrarSesion())
            {
                frmLogging logging = new frmLogging();
                persona = logging.mostrarLogging();
                if (persona != null)
                {

                    this.Text = "Sistema Academia - Bienvendio " + persona.Apellido + ", " + persona.Nombre;
                    iniciaSesion();
                }
                logging = null;
            }

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

        //private void mnuAñadirUsuario_Click(object sender, EventArgs e)
        //{
        //    ControladorPrincipal cp = new ControladorPrincipal();
        //    cp.agregarUsuario("Fede", "CALVI", 123412);
        //}

        private void mnuPermisos_Click(object sender, EventArgs e)
        {
            frmPermisos permisos = new frmPermisos(persona);
            permisos.MdiParent = this;
            permisos.Show();
        }

        private void mnuUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuario frmUsuario = new frmUsuario(persona);
            frmUsuario.MdiParent = this;
            frmUsuario.Show();
        }

        private void mnuPersonas_Click(object sender, EventArgs e)
        {
            frmPersonas frmPersonas = new frmPersonas(persona);
            frmPersonas.MdiParent = this;
            frmPersonas.Show();
        }

        private void mnuMaterias_Click(object sender, EventArgs e)
        {
            frmMaterias frmMaterias = new frmMaterias();
            frmMaterias.MdiParent = this;
            frmMaterias.Show();
        }

        private void mnuInscripciones_Click(object sender, EventArgs e)
        {
            frmInscripciones frmInscripciones = new frmInscripciones();
            frmInscripciones.MdiParent = this;
            frmInscripciones.Show();
        }
    }
}
