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
    public partial class frmMaterias : Form
    {
        public frmMaterias(Persona p)
        {
            InitializeComponent();
            persona = p;
        }

        Persona persona;

        ControladorMaterias controladorMaterias = new ControladorMaterias();

        private void frmMaterias_Load(object sender, EventArgs e)
        {
            consulta();
            chequearPermisos();
        }



        void consulta()
        {
            llenarGrilla();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmAltaMateria frmAltaMateria = new frmAltaMateria();
            frmAltaMateria.ShowDialog();
            consulta();

        }

        void guardar()
        {
            controladorMaterias.actualizaMateria((List<Materias>)(dgvMaterias.DataSource));
            MessageBox.Show("Guardado exitosamente.", "Sistema Academia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            llenarGrilla();
            chequearPermisos();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in dgvMaterias.SelectedCells)
            {
                DataGridViewRow dgvRow = cell.OwningRow;
                Boolean a = controladorMaterias.eliminarMateria(dgvRow.Cells["Nombre"].Value.ToString());
            }
            llenarGrilla();
        }

        void chequearPermisos()
        {
            btnAlta.Visible = controladorMaterias.getPermiso(persona.Usuario, "alta");
            btnBaja.Visible = controladorMaterias.getPermiso(persona.Usuario, "baja");
            btnModifica.Visible = controladorMaterias.getPermiso(persona.Usuario, "modifica");
        }

        void llenarGrilla()
        {
            dgvMaterias.DataSource = controladorMaterias.getMaterias();
            dgvMaterias.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            guardar();
        }
    }
}
