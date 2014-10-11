using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace CapaDeDatos
{
    public class ConnectionString
    {

        private static SqlConnection conexion;

        public static SqlConnection Conexion
        {
            get
            {
                if (conexion == null)
                {
                    conexion = new SqlConnection(@"Data Source=FEDEE\SQLSERVER;Initial Catalog=Academia;Integrated Security=true"); 
                }
                return conexion;
            }
        }
    }
}

    

