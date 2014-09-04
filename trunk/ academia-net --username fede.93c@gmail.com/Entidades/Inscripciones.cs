using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Inscripciones
    {
        public int Legajo { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string NombreMateria { get; set; }
        public DateTime fecha { get; set; }
        public int nroMateria { get; set; }
    }
}
