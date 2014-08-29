using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Permiso
    {
        public string Usuario { get; set; }
        public bool Alta { get; set; }
        public bool Baja { get; set; }
        public bool Modifica { get; set; }
        public bool Consulta { get; set; }
        public string Modulo { get; set; }
        public int nroModulo { get; set; }

    }
}
