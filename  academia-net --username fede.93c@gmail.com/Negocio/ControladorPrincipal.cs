using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using CapaDeDatos;

namespace Negocio
{
    public class ControladorPrincipal
    {
        public void agregarUsuario(string Nombre, string Apellido, string Legajo)
        {
            CatalogoPersonas datos = new CatalogoPersonas();
            Persona persona = new Persona();
            persona.Nombre = Nombre;
            persona.Apellido = Apellido;
            persona.Legajo = Legajo;
            datos.agregarPersona(persona);
        }
    }
}
