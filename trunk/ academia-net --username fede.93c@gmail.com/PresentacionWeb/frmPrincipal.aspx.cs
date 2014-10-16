using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;

public partial class frmPrincipal : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Persona persona = ((Persona)Session["persona"]);
        if (persona == null)
        {
            lblInicio.Text = "Hola, para comenzar, inicie sesion en el panel derecho";
        }
        else
        {
            lblInicio.Text = "Bienvenido " + persona.Apellido + ", " + persona.Nombre;
        }
    }
}