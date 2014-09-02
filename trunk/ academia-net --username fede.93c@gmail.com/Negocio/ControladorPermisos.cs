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
        CatalogoPermisos cp;
        CatalogoUsuarios cU;
        CatalogoModulos cM;

        public ControladorPermisos()
        {
            cp = new CatalogoPermisos();
            cU = new CatalogoUsuarios();
            cM = new CatalogoModulos(); 
        }
        public Permiso[] getUsuariosyPermisos()
        {         
            Permiso[] permisos = cp.getPermisos();
            return permisos;
        }

        public Usuario[] getUsuarios()
        {
            return cU.getUsuarios();
        }

        public bool getPermisoUsuarioModulo(string Usuario, string nombreModulo)
        {
            Permiso[] permisos = cp.getPermisos();
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
                cp.actualizarPermisos(permiso);
            }
        }

        public Modulo[] getModulos()
        {
            Modulo[] modulos = cM.getModulos();
            return modulos;
        }

        public Modulo[] getModulosSinUso(string usuario)
        {
            Modulo[] modulos = cM.getModulosSinUso(usuario);
            return modulos;
        }


        public bool agregarPermiso(string usuario, string modulo, bool alta, bool baja, bool modifica, bool consulta)
        {
            int nroMod = cM.getNroModulo(modulo).Id_mod;
            return cp.agregarPermiso(usuario, nroMod, alta, baja, modifica, consulta);
        }

       
    }
}



    
     