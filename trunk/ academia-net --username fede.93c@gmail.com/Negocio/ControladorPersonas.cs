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
    }
}
