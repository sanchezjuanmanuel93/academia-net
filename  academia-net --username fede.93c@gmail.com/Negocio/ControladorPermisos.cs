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

        public ControladorPermisos()
        {
            cp = new CatalogoPermisos();
        }
        public Permiso[] getUsuariosyPermisos()
        {         
            Permiso[] permisos = cp.getPermisos();
            return permisos;
        }

        public bool getPermisoUsuarioModulo(string Usuario, string nombreModulo)
        {
            Permiso[] permisos = cp.getPermisos();
            foreach (Permiso permiso in permisos)
            {
                if (permiso!=null)
                {
                    if ((permiso.Usuario == Usuario) && (permiso.Modulo == nombreModulo))
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


       
    }
}



    
     