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
    ControladorInscripciones controladorInscripciones = new ControladorInscripciones();

    protected void Page_Load(object sender, EventArgs e)
    {
        persona = (Persona)Session["persona"];
        llenarCombo();
    }
    void llenarCombo()
    {
        cmbMaterias.DataSource = controladorInscripciones.getMateriasSinInscripcion(persona.Legajo);
        cmbMaterias.DataTextField = "Nombre";
        cmbMaterias.DataValueField = "nroMateria";
        cmbMaterias.DataBind();
    }
    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        List<Materias> materias = controladorInscripciones.getMateriasSinInscripcion(persona.Legajo);

        if (controladorInscripciones.agregarInscripcion(persona.Legajo, materias[cmbMaterias.SelectedIndex].nroMateria.ToString(), DateTime.Now))
        {
            Response.Redirect("~/frmInscripciones.aspx");
        }

        else
        {
            //MessageBox.Show("Error");
        }
    }
}