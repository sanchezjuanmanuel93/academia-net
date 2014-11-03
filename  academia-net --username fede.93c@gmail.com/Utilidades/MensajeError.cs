using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilidades
{
    public class MensajeError
    {
        public static void mostrarMensaje(List<String> errores)
        {
            String cadena = "";
            foreach (String error in errores)
            {
                cadena += error + '\n';
            }
            System.Windows.Forms.MessageBox.Show(cadena, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        }

        public static void mostrarMensaje(String error)
        {
            List<String> errores = new List<String>();
            errores.Add(error);
            mostrarMensaje(errores);
        }
    }
}
