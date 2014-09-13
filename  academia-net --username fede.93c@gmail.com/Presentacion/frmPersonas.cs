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
    public partial class frmPersonas : Form
    {
        public frmPersonas(Persona p)
        {
            InitializeComponent();
            persona = p;
        }

        ControladorPersonas controladorPersonas = new ControladorPersonas();
        Persona persona;
        bool cambios = false;

        private void frmPersonas_Load(object sender, EventArgs e)
        {
            llenarGrilla();
            chequearPermisos();
            dgvPersonas.Columns["Legajo"].ReadOnly = true;
        }

        void chequearPermisos()
        {
            btnAlta.Visible = controladorPersonas.getPermiso(persona.Usuario, "alta");
            btnBaja.Visible = controladorPersonas.getPermiso(persona.Usuario, "baja");
            btnGuardar.Visible = controladorPersonas.getPermiso(persona.Usuario, "modifica");
        }

        void llenarGrilla()
        {
            dgvPersonas.DataSource = controladorPersonas.getPersonas();
            dgvPersonas.Columns["Usuario"].Visible = false;
            dgvPersonas.Columns["mostrar"].Visible = false;
            dgvPersonas.Columns["Tipo"].Visible = false;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmAltaPersonas frmAltaPersona = new frmAltaPersonas();
            frmAltaPersona.ShowDialog();
            llenarGrilla();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in dgvPersonas.SelectedCells)
            {
                DataGridViewRow dgvRow = cell.OwningRow;
                controladorPersonas.eliminarPersona(dgvRow.Cells["Legajo"].Value.ToString());
            }
            llenarGrilla();
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            controladorPersonas.actualizarPersona((List<Persona>)dgvPersonas.DataSource);
            cambios = false;
        }

        private void frmPersonas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cambios)
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

        void guardar()
        {
            controladorPersonas.actualizarPersona((List<Persona>)dgvPersonas.DataSource);
            MessageBox.Show("Guardado exitosamente.", "Sistema Academia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            llenarGrilla();
            chequearPermisos();
        }

        private void dgvPersonas_Click(object sender, EventArgs e)
        {
            cambios = true;
        }
    }
}