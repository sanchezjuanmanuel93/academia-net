using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using Negocio;
using Entidades;
using Utilidades;

namespace Presentacion
{
    public partial class frmInformeMaterias : Form
    {
        Int32[] legajos;
        String legajoSeleccionado;
        List<Persona> lista;
        

        public frmInformeMaterias()
        {
            InitializeComponent();
            lista = new ControladorPersonas().getPersonas();
            this.cmbPersonas.DataSource = lista;
            legajos = new Int32[lista.Count];
            for (int x =0; x< lista.Count; x++)
            {
                legajos[x] = Convert.ToInt32(lista.ElementAt(x).Legajo);
            }
            this.cmbPersonas.DisplayMember = "mostrar";
        }

        private void btnInforme_Click(object sender, EventArgs e)
        {
            legajoSeleccionado = lista.ElementAt(this.cmbPersonas.SelectedIndex).Legajo;
            ControladorInscripciones adaptador = new ControladorInscripciones();
            List<Inscripciones> inscripciones = adaptador.getInscripciones(legajoSeleccionado);
            InformeMaterias reporte = new InformeMaterias();
            DataSetInforme ds = new DataSetInforme();
            if(inscripciones.Count > 0)
            {
                foreach (Inscripciones insc in inscripciones)
                {
                DataSetInforme.InscripcionRow insc_ds = ds.Inscripcion.NewInscripcionRow();
                insc_ds.Apellido = insc.Apellido;
                insc_ds.Nombre = insc.Nombre;
                insc_ds.Nombre_Materia = insc.NombreMateria;
                insc_ds.Nro_Materia = Convert.ToString(insc.nroMateria);
                insc_ds.Fecha = insc.fecha.Day.ToString() +"/"+ insc.fecha.Month.ToString() +"/"+ insc.fecha.Year.ToString();
                ds.Inscripcion.AddInscripcionRow(insc_ds);
                }
            }
            reporte.SetDataSource(ds);
            this.crvDatos.ReportSource = reporte;
            this.crvDatos.Refresh();
        }
    }
}
