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
    public partial class frmInscripciones : Form
    {
        public frmInscripciones(Persona p)
        {
            InitializeComponent();
            persona = p;
        }
        Persona persona;
        ControladorInscripciones controladorInscripciones = new ControladorInscripciones();

        private void frmInscripciones_Load(object sender, EventArgs e)
        {
            actualizar();

        }

        void actualizar()
        {
            try
            {
                dgvInscripciones.DataSource = controladorInscripciones.getInscripciones(persona.Legajo);
                dgvInscripciones.Columns["nroMateria"].Visible = false;
            }
            catch (Exception)
            {
                
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmAltaInscripcion frm = new frmAltaInscripcion(persona);
            frm.ShowDialog();
            actualizar();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in dgvInscripciones.SelectedCells)
            {
                DataGridViewRow dgvRow = cell.OwningRow;
                controladorInscripciones.eliminarInscripcion(dgvRow.Cells["Legajo"].Value.ToString(), dgvRow.Cells["nroMateria"].Value.ToString());
            }
            actualizar();
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {

        }

        private void dgvInscripciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
