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
            if (controladorPersonas.agregarPersona(txtLegajo.Text, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtEmail.Text, ((TipoPersona)cmbTipo.SelectedItem).tipo))
            {
                MessageBox.Show("Agregada");
                this.Close();
            }
            else
                MessageBox.Show("Persona existente o campos incorrectos");
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




    }
}
