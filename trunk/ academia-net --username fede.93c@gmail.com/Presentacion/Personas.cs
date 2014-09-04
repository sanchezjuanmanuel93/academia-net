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
        public frmPersonas()
        {
            InitializeComponent();
        }

        ControladorPersonas controladorPersonas = new ControladorPersonas();


        private void frmPersonas_Load(object sender, EventArgs e)
        {
            llenarGrilla();
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
    }
}