using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;

public partial class frmLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    Persona persona;
    protected void btnIngresar_Click(object sender, EventArgs e)
    {
        ControladorLogging login = new ControladorLogging();
        if (!(txtUsuario.Text == string.Empty && txtContraseña.Text == string.Empty))
        {
            if (login.ingresar(txtUsuario.Text, txtContraseña.Text))
            {
                persona = login.getPersona();
                lblMensaje.Text = persona.Apellido + ", " + persona.Nombre;
                Session["persona"] = persona;
                Response.Redirect("~/frmPrincipal.aspx");
            }
            else
            {
                lblMensaje.Text = "Usuario o contraseña incorrectos";
            }            
        }
        else
        {
            lblMensaje.Text = "Por favor, complete los campos";
        }
       
    }
}