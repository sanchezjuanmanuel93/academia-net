using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;

public partial class frmAltaInscripcion : System.Web.UI.Page
{
    Persona persona;
    String[] materias;
    String[] idmateria;
    ControladorInscripciones controladorInscripciones = new ControladorInscripciones();
    ControladorPersonas controladorPersona = new ControladorPersonas();
    ControladorUsuarios controladorUsuarios = new ControladorUsuarios();
    ControladorPermisos controladorPermisos = new ControladorPermisos();
    ControladorMaterias controladorMaterias = new ControladorMaterias();

    protected void Page_Load(object sender, EventArgs e)
    {
        persona = (Persona)Session["persona"];
        if (persona != null)
        {
            Usuario usuarioCorrespondiente = controladorPersona.getUsuarioCorrespondiente(persona);
            Boolean permiso = controladorPermisos.getPermiso(usuarioCorrespondiente.Usu, "alta", "inscripciones");
            if (!permiso)
            {
                Response.Redirect("~/frmInscripciones.aspx");
            }
        }
        else
        {
            Response.Redirect("~/frmInscripciones.aspx");
        }
        this.llenarCombo();
    }

    protected void llenarCombo()
    {
        List<Materias> listado = controladorMaterias.getMaterias();
        List<String> cadenas = new List<string>();
        foreach (Materias mat in listado)
        {
            cadenas.Add(mat.Nombre);
        }
        this.cmbMaterias.DataSource = cadenas;
        this.cmbMaterias.DataBind();
        materias = new string[listado.Count];
        idmateria = new string[listado.Count];
        for (int i = 0; i < listado.Count; i++)
        {
            materias[i] = listado.ElementAt(i).Nombre;
            idmateria[i] = Convert.ToString(listado.ElementAt(i).nroMateria);
        }
    }
 
    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        String id = "";
        for (int i = 0; i < materias.Length; i++)
        {
            if (materias[i].Equals(this.cmbMaterias.SelectedItem.Value))
            {
                id = idmateria[i];
            }
        }
        Boolean a = controladorInscripciones.agregarInscripcion(persona.Legajo, id, DateTime.Now);
        Response.Redirect("~/frmInscripciones.aspx");
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/frmInscripciones.aspx");
    }
}