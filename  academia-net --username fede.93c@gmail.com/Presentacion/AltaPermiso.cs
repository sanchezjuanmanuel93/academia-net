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
    public partial class AltaPermiso : Form
    {
        
        public AltaPermiso()
        {
            InitializeComponent();
        }

        ControladorPermisos cP = new ControladorPermisos();

        private void AltaPermiso_Load(object sender, EventArgs e)
        {
            cmbUsuario.DataSource = cP.getUsuarios();
            cmbUsuario.DisplayMember = "Usu";
        }

        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            Modulo[] modulos = cP.getModulosSinUso(((Entidades.Usuario)cmbUsuario.SelectedItem).Usu);
            cmbModulo.DataSource = modulos;
            cmbModulo.DisplayMember = "modulo";
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbModulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            desbloquearChk();
        }

        void desbloquearChk()
        {
            chkAlta.Enabled = chkBaja.Enabled = chkConsulta.Enabled = chkModifica.Enabled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool ok = cP.agregarPermiso(((Entidades.Usuario)cmbUsuario.SelectedItem).Usu, ((Entidades.Modulo)cmbModulo.SelectedItem).modulo, chkAlta.Checked, chkBaja.Checked, chkModifica.Checked, chkConsulta.Checked);
            if (ok)
            {
                MessageBox.Show("Permiso agregado con exito", "Ingreso exitoso", MessageBoxButtons.OK,  MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se puedo agregar el permiso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}
