using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;


public partial class frmAltaPermisos : System.Web.UI.Page
{
    Persona persona;
    ControladorPersonas controladorPersonas = new ControladorPersonas();
    ControladorPermisos controladorPermisos = new ControladorPermisos();
    ControladorUsuarios controladorUsuarios = new ControladorUsuarios();

    protected void Page_Load(object sender, EventArgs e)
    {
        persona = (Persona)Session["persona"];
        if (persona != null)
        {
            Usuario usuarioCorrespondiente = controladorPersonas.getUsuarioCorrespondiente(persona);
            Boolean permiso = controladorPermisos.getPermiso(usuarioCorrespondiente.Usu, "alta", "permisos");
            if (!permiso)
            {
                Response.Redirect("~/frmPermisos.aspx");
            }
        }
        else
        {
            Response.Redirect("~/frmPermisos.aspx");
        }
        if (!this.IsPostBack)
        {
            llenarComboUsuarios();
        }
    }
    protected void ddlUsuarios_SelectedIndexChanged(object sender, EventArgs e)
    {
        llenarComboModulos();
    }

    protected void llenarComboUsuarios()
    {
        List<Usuario> usuarios = controladorUsuarios.getUsuarios();
        List<String> cadenas = new List<String>();
        foreach (Usuario user in usuarios)
        {
            cadenas.Add(user.Usu);
        }
        this.ddlUsuarios.DataSource = cadenas;
        this.ddlUsuarios.DataBind();
    }

    protected void llenarComboModulos()
    {
        List<Modulo> modulos = controladorPermisos.getModulosSinUso(this.ddlUsuarios.SelectedItem.Value).ToList();
        List<String> cadenas = new List<String>();
        foreach (Modulo mod in modulos)
        {
            cadenas.Add(mod.modulo);
        }
        ddlModulos.DataSource = cadenas;
        ddlModulos.DataBind();
    }
    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        controladorPermisos.agregarPermiso(this.ddlUsuarios.SelectedItem.Value, this.ddlModulos.SelectedValue, false, false, false, false);
        Response.Redirect("~/frmPermisos.aspx");
    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/frmPermisos.aspx");
    }
}