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
        public frmMaterias()
        {
            InitializeComponent();
        }

        ControladorMaterias controladorMaterias = new ControladorMaterias();

        private void frmMaterias_Load(object sender, EventArgs e)
        {
            consulta();
        }

        void consulta()
        {
            dgvMaterias.DataSource = controladorMaterias.getMaterias();
            dgvMaterias.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmAltaMateria frmAltaMateria = new frmAltaMateria();
            frmAltaMateria.ShowDialog();
            consulta();

        }
    }
}
