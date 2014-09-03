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
        
        public frmUsuario()
        {
            InitializeComponent();
        }

        ControladorUsuarios cU = new ControladorUsuarios();

        private void Usuario_Load(object sender, EventArgs e)
        {
            llenarGrilla();
        }

        void llenarGrilla()
        {
            dgvUsuarios.DataSource = cU.getUsuarios();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in dgvUsuarios.SelectedCells)
            {
                DataGridViewRow fila = cell.OwningRow;
                cU.eliminarUsuario(fila.Cells["Usu"].Value.ToString());
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
    }
}
