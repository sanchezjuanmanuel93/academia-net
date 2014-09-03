using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace Presentacion
{
    public partial class frmPermisos : Form
    {
        public frmPermisos()
        {
            InitializeComponent();
        }

        ControladorPermisos cp = new ControladorPermisos();


        private void Permisos_Load(object sender, EventArgs e)
        {
            llenarGrilla();
        }

        void llenarGrilla()
        {
            dgvPermisos.DataSource = cp.getUsuariosyPermisos();
            dgvPermisos.Columns["nroModulo"].Visible = false;
            dgvPermisos.Columns["Usuario"].ReadOnly = true;
            dgvPermisos.Columns["Modulo"].ReadOnly = true;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmAltaPermiso altaPermiso = new frmAltaPermiso();
            altaPermiso.ShowDialog();
            llenarGrilla();
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        void guardar()
        {
            cp.actualizaPermisos((Permiso[])dgvPermisos.DataSource);
            MessageBox.Show("Guardado exitosamente.", "Sistema Academia", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in dgvPermisos.SelectedCells)
            {
                DataGridViewRow fila = cell.OwningRow;
                cp.eliminarPermiso(fila.Cells["Usuario"].Value.ToString(), fila.Cells["Modulo"].Value.ToString());
            }
            llenarGrilla();
        }

        private void Permisos_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (MessageBox.Show("Desea guardar los cambios?", "Atento!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question))
            {

                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                case DialogResult.No:
                    break;
                case DialogResult.Yes:
                    guardar();
                    break;
                default:
                    break;
            }
        }

    }
}
