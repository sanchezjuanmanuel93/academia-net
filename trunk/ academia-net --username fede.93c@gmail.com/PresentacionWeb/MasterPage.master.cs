using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;


public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["persona"] == null)
        {
            lnkCerrarSesion.Visible = false;
            lnkIniciarSesion.Visible = true;
            foreach (MenuItem item in Menu1.Items)
            {
                if (item.Text != "Inicio")
                {
                    item.Text = "";
                }
            }            
        }
        else
        {
            lnkCerrarSesion.Visible = true;
            lnkIniciarSesion.Visible = false;
            controlarPermisos();
        }
    }

    void controlarPermisos()
    {
        ControladorPermisos cP = new ControladorPermisos();
        Persona persona = ((Persona)Session["persona"]);
        foreach (MenuItem item in Menu1.Items)
        {
            if (item.Text != "Inicio")
            {
                if( cP.getPermisoUsuarioModulo(persona.Usuario, item.Value) == false)
                {
                    item.Text = "";
                }
                else
                {
                    item.Text = "| " + item.Value;
                }
                
            }

        }
    }
    protected void lnkIniciarSesion_Click(object sender, EventArgs e)
    {
        Session["persona"] = null;
        Response.Redirect("~/frmLogin.aspx");
    }
    protected void lnkCerrarSesion_Click(object sender, EventArgs e)
    {
        Session["persona"] = null;
        Response.Redirect("~/frmPrincipal.aspx");
    }
    protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
    {
        switch (e.Item.Value)
        {
            case "Inicio":
                Response.Redirect("~/frmPrincipal.aspx");
                break;
            case "Inscripciones":
                Response.Redirect("~/frmInscripciones.aspx");
                break;
            case "Permisos":
                Response.Redirect("~/frmPermisos.aspx");
                break;
            case "Materias":
                Response.Redirect("~/frmMaterias.aspx");
                break;
            case "Usuarios":
                Response.Redirect("~/frmUsuarios.aspx");
                break;
            case "Personas":
                Response.Redirect("~/frmPersonas.aspx");
                break;
            default:
                break;
        }
    }
}
