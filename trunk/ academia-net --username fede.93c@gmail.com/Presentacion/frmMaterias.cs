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
            dgvMaterias.DataSource = controladorMaterias.getMaterias();
        }
    }
}
