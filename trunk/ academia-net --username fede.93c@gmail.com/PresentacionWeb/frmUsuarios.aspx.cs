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
    protected void Page_Load(object sender, EventArgs e)
    {

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