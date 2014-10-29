using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;

public partial class frmMaterias : System.Web.UI.Page
{
    Persona persona;
    ControladorMaterias controladorMaterias;

    protected void Page_Load(object sender, EventArgs e)
    {
        persona = (Persona)Session["persona"];
        controladorMaterias = new ControladorMaterias();
 
    }
    protected void btnAlta_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/frmAltaMaterias.aspx");
    }
    protected void btnBaja_Click(object sender, EventArgs e)
    {
        GridViewRow fila = dgvMaterias.SelectedRow;
        if (fila != null)
        {
            controladorMaterias.eliminarMateria(fila.Cells[2].Text);
        }
    }
    protected void btnGuardar_Click(object sender, EventArgs e)
    {

    }
}