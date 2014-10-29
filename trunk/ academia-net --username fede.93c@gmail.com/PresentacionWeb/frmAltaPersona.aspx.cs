using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;


public partial class frmAltaPersona : System.Web.UI.Page
{
    Persona persona;
    ControladorPersonas controladorPersonas = new ControladorPersonas();

    protected void Page_Load(object sender, EventArgs e)
    {
        persona = (Persona)Session["persona"];
    }
    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        String valorTipo = ddlTipo.SelectedValue;
        if ((txtLegajo.Text != null) && (txtNombre.Text != null) && (txtApellido.Text != null) && (txtTelefono.Text != null) && (txtEmail.Text != null) && (valorTipo != null) )
        {
            
            if (controladorPersonas.agregarPersona(txtLegajo.Text, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtEmail.Text, Convert.ToInt32(valorTipo)))
            {
                lblMensaje.Text = "Agregada";
                Response.Redirect("~/frmPersonas.aspx");
            }
            else
            {
                lblMensaje.Text = "Persona existente o campos incorrectos";
            }
        }
        else
        {
            lblMensaje.Text = "Complete todos los campos correctamente";
        }
    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/frmPersonas.aspx");
    }
}