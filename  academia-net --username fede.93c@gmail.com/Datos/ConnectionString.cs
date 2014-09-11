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
                    conexion = new SqlConnection("Data Source=190.244.225.191,1433\\SQLSERVER08R2;Initial Catalog=Academia;User ID=sa;Password=123"); 
                }
                return conexion;
            }
        }
    }
}

    

