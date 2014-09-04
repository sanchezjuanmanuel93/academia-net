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
        public frmPermisos(Persona p)
        {
            InitializeComponent();
            persona = p;
        }

        Persona persona;
        ControladorPermisos controladorPermisos = new ControladorPermisos();


        private void Permisos_Load(object sender, EventArgs e)
        {
            llenarGrilla();
            chequearPermisos();
        }

        void chequearPermisos()
        {
            btnAlta.Visible = controladorPermisos.getPermiso(persona.Usuario, "alta");
            btnBaja.Visible = controladorPermisos.getPermiso(persona.Usuario, "baja");

            if ((btnBaja.Visible == false) && (btnAlta.Visible == false))
            {
                btnGuardar.Visible = false;
            }


            bool modifica = !controladorPermisos.getPermiso(persona.Usuario, "modifica");
            dgvPermisos.Columns["Alta"].ReadOnly = modifica;
            dgvPermisos.Columns["Baja"].ReadOnly = modifica;
            dgvPermisos.Columns["Modifica"].ReadOnly = modifica;
            dgvPermisos.Columns["Consulta"].ReadOnly = modifica;


        }

        void llenarGrilla()
        {
            dgvPermisos.DataSource = controladorPermisos.getUsuariosyPermisos();
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
            controladorPermisos.actualizaPermisos((Permiso[])dgvPermisos.DataSource);
            MessageBox.Show("Guardado exitosamente.", "Sistema Academia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            llenarGrilla();
            chequearPermisos();
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
                controladorPermisos.eliminarPermiso(fila.Cells["Usuario"].Value.ToString(), fila.Cells["Modulo"].Value.ToString());
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

        private void dgvPermisos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPermisos_Click(object sender, EventArgs e)
        {

        }

        private void frmPermisos_Click(object sender, EventArgs e)
        {

        }

    }
}
