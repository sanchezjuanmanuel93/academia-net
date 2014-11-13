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

namespace Presentacion
{
    public partial class frmInformeMaterias : Form
    {
        Int32[] legajos;
        public frmInformeMaterias()
        {
            InitializeComponent();
            List<Persona> lista = new ControladorPersonas().getPersonas();
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
            ReportDocument reporte = new ReportDocument();
            Int32 legajo = legajos[this.cmbPersonas.SelectedIndex];
            reporte.Load(@"D:\Academia\Academia\ academia-net --username fede.93c@gmail.com\Presentacion\crpMaterias.rpt");
            reporte.SetParameterValue(0, legajo); 
            this.crvDatos.ReportSource = reporte;
            this.crvDatos.Refresh();
        }
    }
}
