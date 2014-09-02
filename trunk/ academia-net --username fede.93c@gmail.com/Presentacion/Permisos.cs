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
            AltaPermiso altaPermiso = new AltaPermiso();
            altaPermiso.ShowDialog();
            llenarGrilla();
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            cp.actualizaPermisos((Permiso[])dgvPermisos.DataSource);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
