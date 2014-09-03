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
        CatalogoUsuarios cU;
        CatalogoPersonas cP;

        public ControladorUsuarios()
        {
            cU = new CatalogoUsuarios();
            cP = new CatalogoPersonas();
        }

        public List<Usuario> getUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            usuarios.AddRange(cU.getUsuarios());
            return usuarios;
        }

        public bool eliminarUsuario(string usuario)
        {
            return cU.eliminarUsuario(usuario);
        }

        public List<Persona> getPersonas()
        {
            List<Persona> personas = new List<Persona>();

            personas = cP.getPersonasSinUsuario();

            return personas;
        }

        public bool agregarUsuario(Persona persona, string usuario, string clave)
        {
            return cU.agregaUsuario(int.Parse(persona.Legajo), usuario, clave); ;
        }
    }
}
