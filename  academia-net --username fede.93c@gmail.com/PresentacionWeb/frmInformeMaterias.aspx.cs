using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;
using Utilidades;

public partial class frmInformeMaterias : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            if (!this.IsPostBack)
            {
                Persona persona = (Persona)Session["persona"];
                if (persona != null)
                {
                    ControladorPersonas controladorPersonas = new ControladorPersonas();
                    ControladorPermisos controladorPermisos  = new ControladorPermisos();
                    Usuario usuarioCorrespondiente = controladorPersonas.getUsuarioCorrespondiente(persona);
                    Boolean permiso = controladorPermisos.getPermiso(usuarioCorrespondiente.Usu, "consulta", "materias");
                    if (!permiso)
                    {
                        Response.Redirect("~/frmPrincipal.aspx");
                    }
                }
                else
                {
                    Response.Redirect("~/frmPrincipal.aspx");
                }
            }
            List<Persona> lista = new ControladorPersonas().getPersonas();
            List<String> datos = new List<String>();
            Int32[] legajos = new Int32[lista.Count];
            this.Session["lista"] = lista;
            this.Session["legajos"] = legajos;
            foreach (Persona per in lista)
            {
                datos.Add(per.Mostrar);
            }
            this.ddlPersonas.DataSource = datos;
            this.ddlPersonas.DataBind();
            for (int x = 0; x < lista.Count; x++)
            {
                legajos[x] = Convert.ToInt32(lista.ElementAt(x).Legajo);
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        List<Persona> lista = (List<Persona>)this.Session["lista"];
        Int32[] legajos = (Int32[])this.Session["legajos"];
        String legajoSeleccionado = lista.ElementAt(this.ddlPersonas.SelectedIndex).Legajo;
        ControladorInscripciones adaptador = new ControladorInscripciones();
        List<Inscripciones> inscripciones = adaptador.getInscripciones(legajoSeleccionado);
        InformeMaterias reporte = new InformeMaterias();
        DataSetInforme ds = new DataSetInforme();
        if (inscripciones.Count > 0)
        {
            foreach (Inscripciones insc in inscripciones)
            {
                DataSetInforme.InscripcionRow insc_ds = ds.Inscripcion.NewInscripcionRow();
                insc_ds.Apellido = insc.Apellido;
                insc_ds.Nombre = insc.Nombre;
                insc_ds.Nombre_Materia = insc.NombreMateria;
                insc_ds.Nro_Materia = Convert.ToString(insc.nroMateria);
                insc_ds.Fecha = insc.fecha.Day.ToString() + "/" + insc.fecha.Month.ToString() + "/" + insc.fecha.Year.ToString();
                ds.Inscripcion.AddInscripcionRow(insc_ds);
            }
        }
        reporte.SetDataSource(ds);
        this.crViewer.ReportSource = reporte;
        this.crViewer.RefreshReport();
    }
}