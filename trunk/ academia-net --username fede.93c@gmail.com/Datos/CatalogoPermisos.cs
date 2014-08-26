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
        string connectionString = "Data Source=FEDEE-PC\\SQLSERVER08R2;Initial Catalog=tp2_net;Integrated Security=True";

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
            adapter = new SqlDataAdapter("select u.usuario, m.desc_permiso, m.id_permiso from usuarios_permisos um join usuarios u on u.usuario = um.usuario join permisos m on um.id_permiso = m.id_permiso", myCon);
            adapter.Fill(dTable);
            myCon.Close();

            permisos = new Permiso[dTable.Rows.Count];
            
            for (int i = 0; i < permisos.Length; i++)
			{
                permisos[i] = new Permiso();
                permisos[i].Usuario = dTable.Rows[i]["usuario"].ToString();
                permisos[i].permiso = dTable.Rows[i]["desc_permiso"].ToString();
                permisos[i].numPermiso = int.Parse(dTable.Rows[i]["id_permiso"].ToString());
			}

            return permisos;
               
            }
        }
    }

