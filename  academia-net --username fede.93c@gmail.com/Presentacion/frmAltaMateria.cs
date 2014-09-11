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
            if ((txtNumero.Text != null) && (numerico(txtNumero.Text)) && (txtNombre.Text != null))
            {
                if (controladorMaterias.agregarMateria(txtNumero.Text, txtNombre.Text))
                {
                    MessageBox.Show("Materia Agregada Con Exito", "Materia Agregada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Error al agregar materia", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Complete los campos correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmAltaMateria_Load(object sender, EventArgs e)
        {
            txtNumero.Focus();
        }
    }
}
