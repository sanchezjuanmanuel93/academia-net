﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Persona
    {
        public string Legajo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Usuario { get; set; }
        public int Tipo { get; set; }



        public string Mostrar 
        { get
        {
            if (Apellido == "Nueva..")
            {
                return Apellido;
            }
            return Apellido + ", " + Nombre;
        }
        }

        //public string cadena
        //{
        //    get
        //    {
        //        string s = "'" + Legajo + "', '"
        //            + Nombre + "', '" + Apellido + "', '"
        //            + Direccion + "', '" + Email
        //            + "', '" + Telefono + "', '"
        //            + Fecha_Nac + "', '" + "1'";
        //        return s;
        //    }
        //}


    }
}
