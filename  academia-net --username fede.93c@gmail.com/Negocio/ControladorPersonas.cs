using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using CapaDeDatos;

namespace Negocio
{
    public class ControladorPersonas
    {

        CatalogoPersonas catalogoPersona = new CatalogoPersonas();
        CatalogoPermisos catalogoPermisos = new CatalogoPermisos();

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


        public bool getPermiso(string usuario, string boton)
        {
            Permiso[] permisos = catalogoPermisos.getPermisos();
            foreach (Permiso permiso in permisos)
            {
                if (permiso != null)
                {
                    if ((permiso.Usuario == usuario) && (permiso.Modulo == "Personas"))
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
    }
}
