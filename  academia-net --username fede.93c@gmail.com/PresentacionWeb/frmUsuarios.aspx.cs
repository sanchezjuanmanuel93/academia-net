using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Entidades;
public partial class frmUsuarios : System.Web.UI.Page
{
    ControladorPersonas controladorPersonas = new ControladorPersonas();
    ControladorPermisos controladorPermisos = new ControladorPermisos();
    Persona persona;

    protected void Page_Load(object sender, EventArgs e)
    {
        persona = (Persona)Session["persona"];
        if (persona != null)
        {
            Usuario usuarioCorrespondiente = controladorPersonas.getUsuarioCorrespondiente(persona);
            Boolean permiso = controladorPermisos.getPermiso(usuarioCorrespondiente.Usu, "consulta", "usuarios");
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
    protected void btnBaja_Click(object sender, EventArgs e)
    {
        String nombre_usuario = (String)this.grvUsuarios.SelectedRow.Cells[1].Text;
        ControladorUsuarios controlador = new ControladorUsuarios();
        controlador.eliminarUsuario(nombre_usuario);
        this.grvUsuarios.DataBind();

    }

    protected void btnAlta_Click(object sender, EventArgs e)
    {
        this.Response.Redirect("~/frmAltaUsuarios.aspx");
    }
}