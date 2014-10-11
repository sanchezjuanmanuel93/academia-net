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
    public partial class frmAltaUsuario : Form
    {
        public frmAltaUsuario()
        {
            InitializeComponent();
        }

        ControladorUsuarios cU = new ControladorUsuarios();
        bool activar = false;

        private void frmAltaUsuario_Load(object sender, EventArgs e)
        {
            cmbPersona.DataSource = cU.getPersonasSinUsu();
            cmbPersona.DisplayMember = "mostrar";
            
        }

        bool estaModificando = false;

        public void modificar(string legajo, string clave, string usu)
        {
            txtClave.Text = clave;
            txtUsuario.Text = usu;
            txtUsuario.ReadOnly = true;
            estaModificando = true;
            Persona p;
            foreach (var persona in cU.getPersonas())
            {
                if (persona.Legajo == legajo)
                {
                    p = persona;
                    cmbPersona.Text = p.Mostrar;
                    txtUsuario.Enabled = txtClave.Enabled = true;
                    break;
                }
            }
           
        }

        private void cmbPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (activar)
            {

                if (((Persona)(cmbPersona.SelectedItem)).Apellido == "Nueva..")
                {
                    frmAltaPersonas frmAltaPersona = new frmAltaPersonas();
                    frmAltaPersona.ShowDialog();
                    cmbPersona.DataSource = cU.getPersonasSinUsu();
                    cmbPersona.DisplayMember = "mostrar";
                }
                else
                {
                    txtUsuario.Enabled = txtClave.Enabled = true;
                }                
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != string.Empty && txtClave.Text != string.Empty)
            {
                if (estaModificando)
                {
                    Usuario u = new Usuario();
                    u.Legajo = int.Parse(((Persona)(cmbPersona.SelectedItem)).Legajo);
                    u.Clave = txtClave.Text;
                    u.Usu = txtUsuario.Text;
                    if (cU.actualizaUsuario(u))
                    {
                        MessageBox.Show("OK");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("ERROR");
                    }
                }
                else
                {
                    if (cU.agregarUsuario(((Persona)cmbPersona.SelectedItem), txtUsuario.Text, txtClave.Text))
                    {
                        MessageBox.Show("OK");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("ERROR");
                    }
                }
            }
            else
            {
                MessageBox.Show("Complete los campos");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAltaUsuario_Shown(object sender, EventArgs e)
        {
            activar = true;
        }

    }
}
