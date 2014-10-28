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
    public partial class frmUsuario : Form
    {
        
        public frmUsuario(Persona p)
        {
            InitializeComponent();
            persona = p;
        }

        Persona persona;
        ControladorUsuarios controladorUsuarios = new ControladorUsuarios();

        private void Usuario_Load(object sender, EventArgs e)
        {
            llenarGrilla();
            chequearPermisos();
        }

        void chequearPermisos()
        {
            btnAlta.Visible = controladorUsuarios.getPermiso(persona.Usuario, "alta");
            btnBaja.Visible = controladorUsuarios.getPermiso(persona.Usuario, "baja");
            btnModifica.Visible = controladorUsuarios.getPermiso(persona.Usuario, "modifica");
        }

        void llenarGrilla()
        {
            dgvUsuarios.DataSource = controladorUsuarios.getUsuarios();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in dgvUsuarios.SelectedCells)
            {
                DataGridViewRow fila = cell.OwningRow;
                controladorUsuarios.eliminarUsuario(fila.Cells["Usu"].Value.ToString());
            }
            llenarGrilla();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            llenarGrilla();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmAltaUsuario frmAltaUsuario = new frmAltaUsuario();
            frmAltaUsuario.ShowDialog();
            llenarGrilla();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                DataGridViewRow fila = dgvUsuarios.SelectedRows[0];
                frmAltaUsuario frm = new frmAltaUsuario();
                frm.Show();
                frm.modificar(fila.Cells["Legajo"].Value.ToString(), fila.Cells["Clave"].Value.ToString(), fila.Cells["Usu"].Value.ToString());
                llenarGrilla();
            }
            else
            {
                MessageBox.Show("No se seleccionó ningun usuario");
            }

        }
    }
}
