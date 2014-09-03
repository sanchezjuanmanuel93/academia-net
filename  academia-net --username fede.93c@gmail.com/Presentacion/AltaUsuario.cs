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

        private void frmAltaUsuario_Load(object sender, EventArgs e)
        {
            cmbPersona.DataSource = cU.getPersonas();
            cmbPersona.DisplayMember = "mostrar";
        }

        private void cmbPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtUsuario.Enabled = txtClave.Enabled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != string.Empty && txtClave.Text != string.Empty)
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
            else
            {
                MessageBox.Show("Complete los campos");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
