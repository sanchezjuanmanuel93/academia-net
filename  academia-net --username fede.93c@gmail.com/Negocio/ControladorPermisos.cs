using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using CapaDeDatos;

namespace Negocio
{
    public class ControladorPermisos
    {
        CatalogoPermisos catalogoPermisos;
        CatalogoUsuarios catalogoUsuarios;
        CatalogoModulos catalogoModulos;

        public ControladorPermisos()
        {
            catalogoPermisos = new CatalogoPermisos();
            catalogoUsuarios = new CatalogoUsuarios();
            catalogoModulos = new CatalogoModulos(); 
        }
        public Permiso[] getUsuariosyPermisos()
        {         
            Permiso[] permisos = catalogoPermisos.getPermisos();
            return permisos;
        }

        public bool getPermiso(string usuario, string boton)
        {
            Permiso[] permisos = catalogoPermisos.getPermisos();
            foreach (Permiso permiso in permisos)
            {
                if (permiso != null)
                {
                    if ((permiso.Usuario == usuario) && (permiso.Modulo == "Permisos"))
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

        public Usuario[] mostrarUsuarios()
        {
            return catalogoUsuarios.getUsuarios();
        }

        public bool eliminarPermiso(string usuario, string modulo)
        {
            int nroMod = catalogoModulos.getNroModulo(modulo);
            catalogoPermisos.eliminarPermiso(usuario, nroMod);
            return true;
        }

        public bool getPermisoUsuarioModulo(string Usuario, string nombreModulo)
        {
            Permiso[] permisos = catalogoPermisos.getPermisos();
            foreach (Permiso permiso in permisos)
            {
                if (permiso!=null)
                {
                    if ((permiso.Usuario == Usuario) && (permiso.Modulo == nombreModulo) && (permiso.Consulta == true))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void actualizaPermisos(Permiso[] permisos)
        {
            foreach (Permiso permiso in permisos)
            {
                catalogoPermisos.actualizarPermisos(permiso);
            }
        }

        public Modulo[] getModulos()
        {
            Modulo[] modulos = catalogoModulos.getModulos();
            return modulos;
        }

        public Modulo[] getModulosSinUso(string usuario)
        {
            Modulo[] modulos = catalogoModulos.getModulosSinUso(usuario);
            return modulos;
        }


        public bool agregarPermiso(string usuario, string modulo, bool alta, bool baja, bool modifica, bool consulta)
        {
            int nroMod = catalogoModulos.getNroModulo(modulo);
            return catalogoPermisos.agregarPermiso(usuario, nroMod, alta, baja, modifica, consulta);
        }


       
    }
}



    
     