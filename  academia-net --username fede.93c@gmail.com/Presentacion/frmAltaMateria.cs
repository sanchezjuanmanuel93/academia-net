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
using Utilidades;

namespace Presentacion
{
    public partial class frmAltaMateria : Form
    {
        public frmAltaMateria()
        {
            InitializeComponent();
        }


        ControladorMaterias controladorMaterias = new ControladorMaterias();

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool numerico(string s)
        {
            int i = 0;
            bool resultado = int.TryParse(s, out i );
            return resultado;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if ((txtNumero.Text != null) && (numerico(txtNumero.Text)))
            {
                if (controladorMaterias.agregarMateria(txtNumero.Text, txtNombre.Text))
                {
                    MessageBox.Show("Materia Agregada Con Exito", "Materia Agregada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Error al agregar materia", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Boolean comprobarCampos()
        {
            Boolean resultado = true;
            if (!Formato.isNombreMateria(this.txtNombre.Text))
            {
                resultado = false;
                MensajeError.mostrarMensaje("Error en el nombre de la materia");
            }
           return resultado;
        }

        private void frmAltaMateria_Load(object sender, EventArgs e)
        {
            txtNumero.Focus();
        }
    }
}
