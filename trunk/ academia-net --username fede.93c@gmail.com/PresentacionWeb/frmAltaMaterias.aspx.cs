using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Entidades;

public partial class frmAltaMaterias : System.Web.UI.Page
{
    ControladorMaterias controladorMaterias;
    Persona persona;
    protected void Page_Load(object sender, EventArgs e)
    {
        persona = (Persona)Session["persona"];
        controladorMaterias = new ControladorMaterias();
    }

    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        if ((txtNumero.Text != null) && (txtNombre.Text != null))
        {
            if (controladorMaterias.agregarMateria(txtNumero.Text, txtNombre.Text))
            {
                lblMensaje.Text = "Materia Agregada Con Exito";
                Response.Redirect("~/frmMaterias.aspx");
            }
            else
                lblMensaje.Text ="Error al agregar materia";
        }
        else
        {
            lblMensaje.Text = "Complete los campos correctamente";
        }
    }
}