using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace CapaDeDatos
{
    public class CatalogoUsuarios
    {
        string connectionString = "Data Source=FEDEE-PC\\SQLSERVER08R2;Initial Catalog=Academia;Integrated Security=True";

        SqlConnection myCon;
        SqlDataAdapter adapter;
        DataTable dTable;

        public CatalogoUsuarios()
        {
            myCon = new SqlConnection(connectionString);
        }


        public Usuario[] getUsuarios()
        {
            Usuario[] usuarios;
            dTable = new DataTable("usuarios");
            myCon.Open();
            adapter = new SqlDataAdapter("select * from Usuario", myCon);
            adapter.Fill(dTable);
            myCon.Close();

            usuarios = new Usuario[dTable.Rows.Count];

            for (int i = 0; i < usuarios.Length; i++)
            {
                usuarios[i] = new Usuario();
                usuarios[i].Usu = dTable.Rows[i]["Usu"].ToString();
                usuarios[i].Clave = dTable.Rows[i]["Clave"].ToString();
                usuarios[i].Legajo = (int)dTable.Rows[i]["Legajo"];
            }

            return usuarios;
        }

    }
}
