﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Entidades;
using Utilidades;

public partial class frmAltaMaterias : System.Web.UI.Page
{
    ControladorUsuarios controladorUsuarios = new ControladorUsuarios();
    ControladorPersonas controladorPersonas = new ControladorPersonas();
    ControladorPermisos controladorPermisos = new ControladorPermisos();
    Persona persona;


    protected void Page_Load(object sender, EventArgs e)
    {
        persona = (Persona)Session["persona"];
        if (persona != null)
        {
            Usuario usuarioCorrespondiente = controladorPersonas.getUsuarioCorrespondiente(persona);
            Boolean permiso = controladorPermisos.getPermiso(usuarioCorrespondiente.Usu, "alta", "usuarios");
            if (!permiso)
            {
                Response.Redirect("~/frmUsuarios.aspx");
            }
        }
        else
        {
            Response.Redirect("~/frmUsuarios.aspx");
        }
        if (!this.IsPostBack)
        {
            List<Persona> listaPersonas = controladorPersonas.getPersonas();
            List<Usuario> listaUsuarios = controladorUsuarios.getUsuarios();
            List<Persona> listaFinal = controladorPersonas.getPersonas();
            for (int x = 0; x < listaPersonas.Count; x++ )
            {
                Persona per = listaPersonas.ElementAt(x);
                String legajo = per.Legajo;
                foreach (Usuario user in listaUsuarios)
                {
                    if (per.Legajo.Equals(user.Legajo.ToString()))
                    {
                        listaFinal = listaFinal.Where(c => c.Legajo != legajo).ToList();
                        break;
                    }
                }
            }
            this.dgvPersonas.DataSource = listaFinal;
            this.dgvPersonas.DataBind();
        }
    }

    protected void btnGuardar_Click1(object sender, EventArgs e)
    {
        if ((this.dgvPersonas.SelectedRow != null) && (Formato.isUsuario(txtUsuario.Text)) && (Formato.isClave(txtClave.Text)))
        {
            Persona persona = new Persona();
            persona.Apellido = this.dgvPersonas.SelectedRow.Cells[3].Text;
            persona.Email = this.dgvPersonas.SelectedRow.Cells[5].Text;
            persona.Nombre = this.dgvPersonas.SelectedRow.Cells[2].Text;
            persona.Telefono = this.dgvPersonas.SelectedRow.Cells[4].Text;
            persona.Legajo = this.dgvPersonas.SelectedRow.Cells[1].Text;
            String usuario = txtUsuario.Text;
            String clave = txtClave.Text;
            controladorUsuarios.agregarUsuario(persona, usuario, clave);
            this.Response.Redirect("~/frmUsuarios.aspx");
        }
        else
        {
            lblMensaje.Text = "Por favor, complete los campos";
        }

    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        this.Response.Redirect("~/frmUsuarios.aspx");
    }
    
}