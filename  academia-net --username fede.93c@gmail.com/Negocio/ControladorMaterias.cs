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
        CatalogoMaterias catalogoMaterias = new CatalogoMaterias();

        public List<Materias> getMaterias()
        {
            return catalogoMaterias.getMaterias();
        }
    }
}
