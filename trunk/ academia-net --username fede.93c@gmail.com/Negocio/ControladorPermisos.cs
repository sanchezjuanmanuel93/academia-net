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
        public List<adaptadorPermisosGrilla> getUsuariosyPermisos()
        {
            CatalogoPermisos cp = new CatalogoPermisos();
            Permiso[] permisos = cp.getPermisos();

            if (permisos.Length != 0)
            {
                List<adaptadorPermisosGrilla> aPG = reAcomodar(permisos);
                
                return aPG;
            }
            return null;
        }

        public List<adaptadorPermisosGrilla> reAcomodar(Permiso[] permisos)
        {
            List<adaptadorPermisosGrilla> aPG = new List<adaptadorPermisosGrilla>();

            for (int i = 0; i < permisos.Length; i++)
            {
                bool existe = false;
                foreach (adaptadorPermisosGrilla per in aPG)
                {
                    if (permisos[i].Usuario == per.Usuario)
                    {
                        existe = true;
                        switch (permisos[i].numPermiso)
                        {
                            case 1:
                                per.Alta = true;
                                break;
                            case 2:
                                per.Baja = true;
                                break;
                            case 3:
                                per.Modificaiones = true;
                                break;
                            case 4:
                                per.Consulta = true;
                                break;
                            default:
                                break;
                        }
                    }
                }
                if (existe == false)
                {
                    adaptadorPermisosGrilla apgTemp = new adaptadorPermisosGrilla();
                    apgTemp.Usuario = permisos[i].Usuario;

                    switch (permisos[i].numPermiso)
                    {
                        case 1:
                            apgTemp.Alta = true;
                            break;
                        case 2:
                            apgTemp.Baja = true;
                            break;
                        case 3:
                            apgTemp.Modificaiones = true;
                            break;
                        case 4:
                            apgTemp.Consulta = true;
                            break;
                        default:
                            break;
                    }

                    aPG.Add(apgTemp);
                }


            }
            return aPG;
        }
    }
}



    
     