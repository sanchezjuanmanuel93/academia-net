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
        public frmInscripciones()
        {
            InitializeComponent();
        }
        ControladorInscripciones controladorInscripciones = new ControladorInscripciones();

        private void frmInscripciones_Load(object sender, EventArgs e)
        {
            dgvInscripciones.DataSource = controladorInscripciones.getInscripciones();
            dgvInscripciones.Columns["nroMateria"].Visible = false;
        }
    }
}
