using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using CapaDeDatos;

namespace Negocio
{
    public class ControladorInscripciones
    {
        CatalogoInscripciones catalogoInscrpciones = CatalogoInscripciones.Instancia;
        CatalogoMaterias catalogoMateria = CatalogoMaterias.Instancia;
        CatalogoPermisos catalogoPermisos = CatalogoPermisos.Instancia;

        List<Inscripciones> Inscripciones;
        public List<Inscripciones> getInscripciones(string legajo)
        {
            if (legajo == "0")
            {
                Inscripciones = catalogoInscrpciones.getInscripciones();
            }
            else
            {
                Inscripciones = catalogoInscrpciones.getInscripciones(legajo);
            }
            return Inscripciones;
        }

        public List<Materias> getMateriasSinInscripcion(string legajo)
        {
            return catalogoMateria.getMateriasSinInscripcion(legajo);
        }

        public bool eliminarInscripcion(string legajo, string idMateria)
        {
            return catalogoInscrpciones.eliminarInscripcion(legajo, idMateria);
        }

        public bool eliminarInscripcion(int Index)
        {
            return catalogoInscrpciones.eliminarInscripcion(Inscripciones[Index].Legajo.ToString(),Inscripciones[Index].nroMateria.ToString());
        }

        public bool getPermiso(string usuario, string boton)
        {
            Permiso[] permisos = catalogoPermisos.getPermisos();
            foreach (Permiso permiso in permisos)
            {
                if (permiso != null)
                {
                    if ((permiso.Usuario == usuario) && (permiso.Modulo == "Inscripciones"))
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

        public bool agregarInscripcion(string legajo, string idMateria, DateTime fecha)
        {
            string f = fecha.ToShortDateString();
            return catalogoInscrpciones.agregaInscripcion(legajo, idMateria, f);
        }

    }
}
