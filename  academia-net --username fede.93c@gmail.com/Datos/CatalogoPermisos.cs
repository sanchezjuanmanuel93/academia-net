using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace CapaDeDatos
{
    public class CatalogoPermisos
    {
        string connectionString = "Data Source=FEDEE-PC\\SQLSERVER08R2;Initial Catalog=Academia;Integrated Security=True";

        SqlConnection myCon;
        SqlDataAdapter adapter;
        DataTable dTable;

        public CatalogoPermisos()
        {
            myCon = new SqlConnection(connectionString);
        }



        public Permiso[] getPermisos()
        {
            Permiso[] permisos;
            dTable = new DataTable("permisos");
            myCon.Open();
            adapter = new SqlDataAdapter("select u.Usu, um.Alta, um.Baja, um.Modifica, um.Consulta, m.Descripcion from Usuarios_Modulos um join Usuario u on um.Usu = u.Usu join Modulo m on um.Id_mod = m.Id_mod", myCon);
            adapter.Fill(dTable);
            myCon.Close();

            permisos = new Permiso[dTable.Rows.Count];
            
            for (int i = 0; i < permisos.Length; i++)
			{
                permisos[i] = new Permiso();
                permisos[i].Usuario = dTable.Rows[i]["Usu"].ToString();
                permisos[i].Alta = (bool)(dTable.Rows[i]["Alta"]);
                permisos[i].Baja = (bool)(dTable.Rows[i]["Baja"]);
                permisos[i].Modifica = (bool)(dTable.Rows[i]["Modifica"]);
                permisos[i].Consulta = (bool)(dTable.Rows[i]["Consulta"]);
                permisos[i].Modulo = dTable.Rows[i]["Descripcion"].ToString();
			}

            return permisos;
               
            }
        }
    }

