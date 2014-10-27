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
    public partial class frmAltaInscripcion : Form
    {
        public frmAltaInscripcion(Persona p)
        {
            InitializeComponent();
            persona = p;
        }

        Persona persona;
        ControladorInscripciones controladorInscripciones = new ControladorInscripciones();

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (controladorInscripciones.agregarInscripcion(persona.Legajo, ((Materias)cmbMateria.SelectedItem).nroMateria.ToString(), DateTime.Now))
            {
                MessageBox.Show("OK");
                this.Close();
            }
            else
                MessageBox.Show("Error");
        }

        private void frmAltaInscripcion_Load(object sender, EventArgs e)

        {
            
            cmbMateria.DataSource = controladorInscripciones.getMateriasSinInscripcion(persona.Legajo);
            cmbMateria.DisplayMember = "Nombre";
        }


    }
}
