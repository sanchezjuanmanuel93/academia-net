using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilidades
{
    public class Formato
    {
        public static Boolean isLegajo(String legajo)
        {
            Boolean resultado = true;
            if (Formato.isLegajoLength(legajo))
            {
                foreach (Char ch in legajo)
                {
                    if (!Char.IsNumber(ch))
                    {
                        resultado = false;
                        break;
                    }
                }
            }
            else
            {
                resultado = false;
            }
            return resultado;
        }

        public static Boolean isLegajo(Int32 legajo)
        {

            Boolean resultado = true;
            if (Formato.isLegajoLength(legajo.ToString()))
            {
                resultado = false;
            }  
            return resultado;
        }

        private static Boolean isLegajoLength(String legajo)
        {
            Boolean resultado;
            if (legajo.Length == 5)
            {
                resultado = true;
            }
            else
            {
                resultado = false;
            }
            return resultado;
        }

        public static Boolean isNombreOApellido(String cadena)
        {
            return isLetrasOBlancos(cadena, false);
        }

        private static bool isLetrasOBlancos(String cadena, Boolean toleraUnNumero)
        {
            Boolean resultado = true;
            if (!String.IsNullOrWhiteSpace(cadena))
            {
                foreach (Char ch in cadena)
                {
                    if (!(Char.IsLetter(ch) || Char.IsWhiteSpace(ch)))
                    {
                        if (toleraUnNumero)
                        {
                            toleraUnNumero = false;
                        }
                        else
                        {
                            resultado = false;
                            break;
                        }
                    }
                }
            }
            else
            {
                resultado = false;
            }
            return resultado;
        }

        public static Boolean isNombreMateria(String materia)
        {
            return Formato.isLetrasOBlancos(materia, true);
        }

        public static Boolean isTelefono(String telefono)
        {
            Boolean resultado = true;
            if (telefono.Length > 20)
            {
                foreach (Char ch in telefono)
                {
                    if (!Char.IsNumber(ch))
                    {
                        resultado = false;
                        break;
                    }
                }
            }
            return resultado;
        }

        public static Boolean isEmail(String email)
        {
            Boolean resultado;
            String sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (System.Text.RegularExpressions.Regex.IsMatch(email, sFormato))
            {
                if (System.Text.RegularExpressions.Regex.Replace(email, sFormato, String.Empty).Length == 0)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
            }
            else
            {
                resultado = false;
            }
            return resultado;
        }

        public static Boolean isUsuario(String cadena)
        {
            Boolean resultado = true;
            if (cadena.Length < 15)
            {
                for (int x = 0; x < cadena.Length; x++)
                {
                    Char ch = cadena.ElementAt(x);
                    if (x == 0)
                    {
                        if (!Char.IsLetter(ch))
                        {
                            resultado = false;
                            break;
                        }
                    }
                    else
                    {
                        if (!(Char.IsLetter(ch) || Char.IsNumber(ch) || ch.Equals('.') || ch.Equals('-') || ch.Equals('_')))
                        {
                            resultado = false;
                            break;
                        }
                    }
                }
            }
            else
            {
                resultado = false;
            }
            return resultado;
        }

        public static Boolean isClave(String clave)
        {
            Boolean resultado = true;
            if (clave.Length < 20)
            {
                foreach (Char ch in clave)
                {
                    if (!(Char.IsNumber(ch) || Char.IsLetter(ch)))
                    {
                        resultado = false;
                        break;
                    }
                }
            }
            else
            {
                resultado = false;
            }
            return resultado;
        }
       

    }
}
