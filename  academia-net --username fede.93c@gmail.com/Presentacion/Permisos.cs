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
    public partial class Permisos : Form
    {
        public Permisos()
        {
            InitializeComponent();
        }

        ControladorPermisos cp = new ControladorPermisos();


        private void Permisos_Load(object sender, EventArgs e)
        {
            dgvPermisos.DataSource = cp.getUsuariosyPermisos();
            dgvPermisos.Columns["nroModulo"].Visible = false;
        }


        private void Permisos_FormClosing(object sender, FormClosingEventArgs e)
        {
            cp.actualizaPermisos((Permiso[])dgvPermisos.DataSource);
        }

    }
}
