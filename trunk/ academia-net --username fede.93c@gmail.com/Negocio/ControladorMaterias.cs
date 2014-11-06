using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using CapaDeDatos;

namespace Negocio
{
    public class ControladorMaterias
    {
        CatalogoMaterias catalogoMaterias = CatalogoMaterias.Instancia;
        CatalogoPermisos catalogoPermisos = CatalogoPermisos.Instancia;

        public List<Materias> getMaterias()
        {
            return catalogoMaterias.getMaterias();
        }

        public bool agregarMateria(string nro, string nombre)
        {
            return catalogoMaterias.agregarMateria(nro, nombre);
        }


        public bool eliminarMateria(string nombre)
        {
            return catalogoMaterias.eliminarMateria(nombre);
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

        public void actualizaMateria(List<Materias> materias)
        {
            foreach (Materias materia in materias)
            {
                actualizaMateria(materia);
            }
        }

        public void actualizaMateria(Materias materia)
        {
            catalogoMaterias.actualizarMaterias(materia);
        }
    }


}
