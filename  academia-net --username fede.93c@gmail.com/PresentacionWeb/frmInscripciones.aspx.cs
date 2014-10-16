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
    protected void Page_Load(object sender, EventArgs e)
    {
        Persona persona = (Persona)Session["persona"];
        ControladorInscripciones controladorInscripciones = new ControladorInscripciones();
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
}