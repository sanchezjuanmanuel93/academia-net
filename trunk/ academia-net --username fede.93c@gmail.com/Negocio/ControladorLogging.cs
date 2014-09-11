using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaDeDatos;
using Entidades;

namespace Negocio
{
    public class ControladorLogging
    {
        CatalogoPersonas datos = CatalogoPersonas.Instancia;

        Persona persona;
        public bool ingresar(string Usuario, string Contraseña)
        {
            datos = new CatalogoPersonas();
            persona = datos.getPersona(Usuario, Contraseña);
            if (persona != null)
            {
                return true;
            }
            return false;
        }

        public Persona getPersona()
        {
            return persona;
        }
    }
}
