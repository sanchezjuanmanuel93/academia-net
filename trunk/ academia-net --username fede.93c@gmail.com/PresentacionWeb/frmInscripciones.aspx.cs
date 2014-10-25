using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;

public partial class frmInscripciones : System.Web.UI.Page
{
    ControladorInscripciones controladorInscripciones;
    Persona persona;
    protected void Page_Load(object sender, EventArgs e)
    {
        persona = (Persona)Session["persona"];
        controladorInscripciones = new ControladorInscripciones();
        llenarGrilla();
    }

    void llenarGrilla()
    {
        
        try
        {
            if (persona != null)
            {
                dgvInscripciones.DataSource = controladorInscripciones.getInscripciones(persona.Legajo);
                dgvInscripciones.DataBind();
            }
        }
        catch (Exception)
        {
        }
    }

    protected void dgvInscripciones_DataBound1(object sender, EventArgs e)
    {

    }
    protected void dgvInscripciones_RowEditing(object sender, GridViewEditEventArgs e)
    {
        dgvInscripciones.EditIndex = e.NewEditIndex;
        dgvInscripciones.DataBind();
    }
    protected void dgvInscripciones_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        dgvInscripciones.EditIndex = -1;
        dgvInscripciones.DataBind();
    }
    protected void dgvInscripciones_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {

    }
    protected void btnBaja_Click(object sender, EventArgs e)
    {
        if (dgvInscripciones.SelectedIndex >= 0)
        {
            controladorInscripciones.eliminarInscripcion(dgvInscripciones.SelectedIndex);
            llenarGrilla();
        }
    }
    protected void btnAlta_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/frmAltaInscripcion.aspx");
    }
}