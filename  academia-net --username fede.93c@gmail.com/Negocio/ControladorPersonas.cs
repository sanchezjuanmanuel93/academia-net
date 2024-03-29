﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using CapaDeDatos;

namespace Negocio
{
    public class ControladorPersonas
    {

        CatalogoPersonas catalogoPersona = CatalogoPersonas.Instancia;
        CatalogoPermisos catalogoPermisos = CatalogoPermisos.Instancia;
        CatalogoUsuarios catalogoUsuarios = CatalogoUsuarios.Instancia;

        public List<Persona> getPersonas()
        {
            return catalogoPersona.getPersonas();
        }

        public bool agregarPersona(string legajo, string nombre, string apellido, string telefono, string email, int tipo)
        {
           return catalogoPersona.agregaPersona(legajo, nombre, apellido, email, telefono, tipo);
        }

        public List<TipoPersona> getTipos()
        {
            return catalogoPersona.getTiposPersona();
        }

        public bool eliminarPersona(string legajo)
        {
           return catalogoPersona.eliminarPersona(legajo);
        }


        public void actualizarPersona(List<Persona> personas)
        {
            foreach (Persona persona in personas)
            {
                 catalogoPersona.actualizarPersonas(persona);     
            }
        }

        public bool getPermiso(string usuario, string boton)
        {
            Permiso[] permisos = catalogoPermisos.getPermisos();
            foreach (Permiso permiso in permisos)
            {
                if (permiso != null)
                {
                    if ((permiso.Usuario == usuario) && (permiso.Modulo == "Materias"))
                    {
                        switch (boton)
                        {
                            case "alta":
                                if (permiso.Alta == true)
                                {
                                    return true;
                                }
                                break;
                            case "baja":
                                if (permiso.Baja == true)
                                {
                                    return true;
                                }
                                break;
                            case "modifica":
                                if (permiso.Modifica == true)
                                {
                                    return true;
                                }
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            return false;
        }

        public Usuario getUsuarioCorrespondiente(Persona persona)
        {
            Usuario[] usuarios = catalogoUsuarios.getUsuarios();
            Usuario resultado = null;
            for (int i = 0; i < usuarios.Length; i++)
            {
                if (usuarios[i].Legajo.ToString().Equals(persona.Legajo))
                {
                    resultado = usuarios[i];
                    break;
                }
            }
            return resultado;
        }
    }


}
