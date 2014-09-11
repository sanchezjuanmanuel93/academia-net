using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Entidades;


namespace CapaDeDatos
{
    public class CatalogoModulos
    {


        private static CatalogoModulos instancia;

        public static CatalogoModulos Instancia
        {
            get
            {
                if (instancia == null)
                {

                    instancia = new CatalogoModulos();
                }
                return instancia;
            }
        }


        SqlConnection myCon;
        SqlDataAdapter adapter;
        DataTable dTable;

        public CatalogoModulos()
        {
            myCon = ConnectionString.Conexion;
        }

        public int getNroModulo(string modulo)
        {
            dTable = new DataTable("modulos");
            myCon.Open();
            adapter = new SqlDataAdapter("select * from Modulo m where m.Descripcion = '" + modulo + "';", myCon);
            adapter.Fill(dTable);
            myCon.Close();

            if (dTable.Rows.Count > 0)
            {
                    return (int)dTable.Rows[0]["Id_mod"];
            }

            return -1;

        }

        public Modulo[] getModulosSinUso(string usuario)
        {
            if (usuario == "")
            {
                return null;
            }
  Modulo[] modulos;
            dTable = new DataTable("Modulos");
            myCon.Open();
            adapter = new SqlDataAdapter("select m.Id_mod, m.Descripcion, u.Usu  from Modulo m inner join Usuario u on 1=1 where u.Usu = '" + usuario + "' EXCEPT select um.Id_mod, m.Descripcion, um.Usu from Usuarios_Modulos um join Modulo m on um.Id_mod = m.Id_mod", myCon);
            adapter.Fill(dTable);
            myCon.Close();

            modulos = new Modulo[dTable.Rows.Count];

            for (int i = 0; i < modulos.Length; i++)
            {
                modulos[i] = new Modulo();
                modulos[i].Id_mod = (int)dTable.Rows[i]["Id_mod"];
                modulos[i].modulo = dTable.Rows[i]["Descripcion"].ToString();
            }

            return modulos;
        }

        public Modulo[] getModulos()
        {
            Modulo[] modulos;
            dTable = new DataTable("Modulos");
            myCon.Open();
            adapter = new SqlDataAdapter("Select * from Modulo", myCon);
            adapter.Fill(dTable);
            myCon.Close();

            modulos = new Modulo[dTable.Rows.Count];

            for (int i = 0; i < modulos.Length; i++)
            {
                modulos[i] = new Modulo();
                modulos[i].Id_mod = (int)dTable.Rows[i]["Id_mod"];
                modulos[i].modulo = dTable.Rows[i]["Descripcion"].ToString();
            }

            return modulos;

        }
    }
}
