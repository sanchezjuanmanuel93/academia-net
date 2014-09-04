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
        CatalogoInscripciones catalogoInscrpciones = new CatalogoInscripciones();

        public List<Inscripciones> getInscripciones()
        {
            return catalogoInscrpciones.getInscripciones();
        }
    }
}
