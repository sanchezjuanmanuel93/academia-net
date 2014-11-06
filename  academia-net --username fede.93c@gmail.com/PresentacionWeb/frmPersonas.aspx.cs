using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;

public partial class frmPersonas : System.Web.UI.Page
{
    Persona persona;
    ControladorPersonas controladorPersonas = new ControladorPersonas();
    ControladorPermisos controladorPermisos = new ControladorPermisos();

    protected void Page_Load(object sender, EventArgs e)
    {
        persona = (Persona)Session["persona"];
        if (persona != null)
        {
            Usuario usuarioCorrespondiente = controladorPersonas.getUsuarioCorrespondiente(persona);
            Boolean permiso = controladorPermisos.getPermiso(usuarioCorrespondiente.Usu, "consulta", "personas");
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
    
    
    protected void btnAlta_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/frmAltaPersona.aspx");
    }
    
    
    protected void btnBaja_Click(object sender, EventArgs e)
    {
        if (dgvPersonas.SelectedIndex != -1)
        {
            controladorPersonas.eliminarPersona(dgvPersonas.SelectedRow.Cells[1].Text);
            lblMensaje.Text = "Se dió de baja correctamente " + dgvPersonas.SelectedRow.Cells[3].Text + " " + dgvPersonas.SelectedRow.Cells[2].Text;
            //llenarGrilla();
        }
        else
        {
            lblMensaje.Text = "Se debe seleccionar alguna Persona";
        }
        
    
    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/frmPrincipal.aspx");
    }

    void llenarGrilla()
    {

        try
        {
            if (persona != null)
            {
                dgvPersonas.DataSource = controladorPersonas.getPersonas();
                dgvPersonas.DataBind();
            }
        }
        catch (Exception)
        {
        }
    }
}