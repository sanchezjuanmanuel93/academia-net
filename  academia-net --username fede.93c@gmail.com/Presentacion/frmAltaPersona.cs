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
using Utilidades;

namespace Presentacion
{
    public partial class frmAltaPersonas : Form
    {
        public frmAltaPersonas()
        {
            InitializeComponent();
        }

        ControladorPersonas controladorPersonas = new ControladorPersonas();

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.comprobarCampos())
            {
                if (controladorPersonas.agregarPersona(txtLegajo.Text, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtEmail.Text, ((TipoPersona)cmbTipo.SelectedItem).tipo))
                {
                    MessageBox.Show("Agregada");
                    this.Close();
                }
                else
                    MessageBox.Show("Persona existente o campos incorrectos");
            }
        }

        private void frmAltaPersonas_Load(object sender, EventArgs e)
        {
            cmbTipo.DataSource = controladorPersonas.getTipos();
            cmbTipo.DisplayMember = "Descripcion";
        }

        private void frmAltaPersonas_Shown(object sender, EventArgs e)
        {
            txtLegajo.Focus();
        }

        private Boolean comprobarCampos()
        {
            Boolean bandera = true;
            List<String> listado = new List<string>();
            if (!Formato.isNombreOApellido(this.txtNombre.Text))
            {
                listado.Add("Error al ingresar el nombre");
                bandera = false;
            }
            if (!Formato.isNombreOApellido(this.txtApellido.Text))
            {
                listado.Add("Error al ingresar el apellido");
                bandera = false;
            }
            if (!Formato.isEmail(this.txtEmail.Text))
            {
                listado.Add("Error al ingresar el email");
                bandera = false;
            }
            if (!Formato.isLegajo(this.txtLegajo.Text))
            {
                listado.Add("Error al ingresar el legajo");
                bandera = false;
            }
            if (!Formato.isTelefono(this.txtTelefono.Text))
            {
                listado.Add("Error al ingresar el telefono");
                bandera = false;
            }
            if (!bandera)
            {
                MensajeError.mostrarMensaje(listado);
            }
            return bandera;
        }

        


    }
}
