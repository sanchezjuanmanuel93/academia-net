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
    public partial class Logging : Form
    {

        ControladorLogging contLogging = new ControladorLogging();
        Persona persona;

        public Logging()
        {
            InitializeComponent();
        }

        public Persona mostrarLogging()
        {
            if (this.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                return persona;
            return null;
        }

        private void Logging_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            txtUsuario.Focus();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != string.Empty && txtContraseña.Text != string.Empty)
            {
                if (contLogging.ingresar(txtUsuario.Text, txtContraseña.Text))
                {
                    persona = contLogging.getPersona();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrectos", "Credencial incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Los campos no pueden estar vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Logging_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIngresar_Click(sender, e);
            }

        }

        private void Logging_FormClosing(object sender, FormClosingEventArgs e)
        {         
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
