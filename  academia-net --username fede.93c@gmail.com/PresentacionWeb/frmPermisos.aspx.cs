using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;

public partial class frmPermisos : System.Web.UI.Page
{

    Persona persona;
    ControladorPermisos controladorPermisos = new ControladorPermisos();
    ControladorPersonas controladorPersonas = new ControladorPersonas();
    static Permiso[] permisos;

    protected void Page_Load(object sender, EventArgs e)
    {
        persona = (Persona)Session["persona"];
        if (persona != null)
        {
            Usuario usuarioCorrespondiente = controladorPersonas.getUsuarioCorrespondiente(persona);
            Boolean permiso = controladorPermisos.getPermiso(usuarioCorrespondiente.Usu, "consulta", "permisos");
            if (!permiso)
            {
                Response.Redirect("~/frmPrincipal.aspx");
            }
        }
        else
        {
            Response.Redirect("~/frmPrincipal.aspx");
        }
        if (!Page.IsPostBack)
        {
            cargar();
        }
    }

    private void cargar()
    {
        llenarGrilla();
        chequearPermisos();

    }


    void chequearPermisos()
    {
        bool modifica, alta, baja;

        alta = controladorPermisos.getPermiso(persona.Usuario, "alta");
        btnAlta.Visible = alta;

        baja = controladorPermisos.getPermiso(persona.Usuario, "baja");
        btnBaja.Visible = baja;
        dgvPermisos.AutoGenerateSelectButton = baja;

        modifica = controladorPermisos.getPermiso(persona.Usuario, "modifica");
        btnGuardar.Visible = modifica;
        foreach (GridViewRow row in dgvPermisos.Rows)
        {           
            foreach (DataControlFieldCell item in row.Controls)
            {
                foreach (var item2 in item.Controls)
                {
                    if (item2 is CheckBox)
                    {
                        ((CheckBox)item2).Enabled = modifica;
                    }
                }
            }
        }
        dgvPermisos.DataBind();
        
    }


    void llenarGrilla()
    {
        permisos = controladorPermisos.getUsuariosyPermisos();
        dgvPermisos.DataSource = permisos;
        dgvPermisos.DataBind();
    }

    public void altaChekedChanged(object sender, EventArgs e)
    {
        CheckBox alta = (CheckBox)sender;
        GridViewRow row = (GridViewRow)alta.NamingContainer;
        permisos[row.RowIndex].Alta = alta.Checked;
    }

    public void bajaChekedChanged(object sender, EventArgs e)
    {
        CheckBox baja = (CheckBox)sender;
        GridViewRow row = (GridViewRow)baja.NamingContainer;
        permisos[row.RowIndex].Baja = baja.Checked;
    }

    public void modificaChekedChanged(object sender, EventArgs e)
    {
        CheckBox modifica = (CheckBox)sender;
        GridViewRow row = (GridViewRow)modifica.NamingContainer;
        permisos[row.RowIndex].Modifica = modifica.Checked;
    }

    public void consultaChekedChanged(object sender, EventArgs e)
    {
        CheckBox consulta = (CheckBox)sender;
        GridViewRow row = (GridViewRow)consulta.NamingContainer;
        permisos[row.RowIndex].Consulta = consulta.Checked;
    }



    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        controladorPermisos.actualizaPermisos(permisos);
        cargar();
    }

    protected void btnBaja_Click(object sender, EventArgs e)
    {
        Permiso p = permisos[dgvPermisos.SelectedIndex];
        controladorPermisos.eliminarPermiso(p.Usuario, p.Modulo);
        cargar();
        dgvPermisos.SelectedIndex = -1;
    }
    protected void btnAlta_Click(object sender, EventArgs e)
    {
        this.Response.Redirect("~/frmAltaPermisos.aspx");
    }
}