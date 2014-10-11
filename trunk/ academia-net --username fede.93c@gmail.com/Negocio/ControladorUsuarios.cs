using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using CapaDeDatos;

namespace Negocio
{
    public class ControladorUsuarios
    {
        CatalogoUsuarios catalogoUsuarios = CatalogoUsuarios.Instancia;
        CatalogoPersonas catalogoPersonas = CatalogoPersonas.Instancia;
        CatalogoPermisos catalogoPermisos = CatalogoPermisos.Instancia;


        public List<Usuario> getUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            usuarios.AddRange(catalogoUsuarios.getUsuarios());
            return usuarios;
        }

        public bool eliminarUsuario(string usuario)
        {
            return catalogoUsuarios.eliminarUsuario(usuario);
        }

        public List<Persona> getPersonasSinUsu()
        {
            List<Persona> personas;

            personas = catalogoPersonas.getPersonasSinUsuario();
            if (personas == null)
            {
                personas = new List<Persona>();   
            }
            Persona p = new Persona();
            p.Apellido = "Nueva..";
            personas.Add(p);
            return personas;
        }

        public List<Persona> getPersonas()
        {
            List<Persona> personas;

            personas = catalogoPersonas.getPersonas();
            if (personas == null)
            {
                personas = new List<Persona>();
            }
            return personas;
        }

        public bool agregarUsuario(Persona persona, string usuario, string clave)
        {
            return catalogoUsuarios.agregaUsuario(int.Parse(persona.Legajo), usuario, clave); ;
        }



        public bool getPermiso(string usuario, string boton)
        {
            Permiso[] permisos = catalogoPermisos.getPermisos();
            foreach (Permiso permiso in permisos)
            {
                if (permiso != null)
                {
                    if ((permiso.Usuario == usuario) && (permiso.Modulo == "Usuarios"))
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

        public void actualizaUsuario(List<Usuario> usuarios)
        {
            foreach (Usuario usuario in usuarios)
            {
                catalogoUsuarios.actualizarUsuarios(usuario);
            }
        }

        public bool actualizaUsuario(Usuario usuario)
        {
           return catalogoUsuarios.actualizarUsuarios(usuario);
        }
    }
}
