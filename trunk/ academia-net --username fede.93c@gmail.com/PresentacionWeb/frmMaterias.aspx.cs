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
    static Persona persona;
    ControladorMaterias controladorMaterias;
    ControladorPermisos controladorPermisos;
    protected void Page_Load(object sender, EventArgs e)
    {
        persona = (Persona)Session["persona"];
        controladorMaterias = new ControladorMaterias();
        controladorPermisos = new ControladorPermisos();
      //  llenarGrilla();
        chequearPermisos();

    }

    static bool modifica, alta, baja;
    void chequearPermisos()
    {
        
        
        alta = controladorMaterias.getPermiso(persona.Usuario, "alta");
        btnAlta.Visible = alta;

        baja = controladorMaterias.getPermiso(persona.Usuario, "baja");
        btnBaja.Visible = baja;
        //dgvMaterias.AutoGenerateSelectButton = baja;

        modifica = controladorMaterias.getPermiso(persona.Usuario, "modifica");
        btnGuardar.Visible = modifica;
        //dgvMaterias.AutoGenerateEditButton = modifica;
        


        dgvMaterias.DataBind();

    }



    void llenarGrilla()
    {

        try
        {
            if (persona != null)
            {
                dgvMaterias.AutoGenerateColumns=true;
                dgvMaterias.DataSource = controladorMaterias.getMaterias();
                dgvMaterias.DataBind();
            }
        }
        catch (Exception)
        {
        }
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

    protected void dgvMaterias_RowDataBound(object sender, GridViewRowEventArgs e)
    {

    }
}