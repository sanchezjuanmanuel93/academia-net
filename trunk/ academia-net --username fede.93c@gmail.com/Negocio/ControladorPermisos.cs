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
        public Permiso[] getUsuariosyPermisos()
        {
            CatalogoPermisos cp = new CatalogoPermisos();
            Permiso[] permisos = cp.getPermisos();
            return permisos;
        }

        public bool getPermisoUsuarioModulo(string Usuario, string nombreModulo)
        {
            CatalogoPermisos cP = new CatalogoPermisos();
            Permiso[] permisos = cP.getPermisos();
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


       
    }
}



    
     