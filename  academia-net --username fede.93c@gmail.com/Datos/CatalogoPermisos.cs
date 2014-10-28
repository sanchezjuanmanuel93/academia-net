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

        private static CatalogoPermisos instancia;

        public static CatalogoPermisos Instancia
        {
            get
            {
                if (instancia == null)
                {

                    instancia = new CatalogoPermisos();
                }
                return instancia;
            }
        }



        SqlConnection myCon;
        SqlDataAdapter adapter;
        DataTable dTable;

        public CatalogoPermisos()
        {
            myCon = ConnectionString.Conexion;
        }


        public bool eliminarPermiso(string usuario, int nroModulo)
        {
            

            int ok =-1;
            string querry = "DELETE FROM Usuarios_Modulos where Usuarios_Modulos.Usu = '" + usuario + "' and Usuarios_Modulos.Id_mod = " + nroModulo;

            SqlCommand cmd = new SqlCommand(querry, myCon);
            cmd.CommandType = CommandType.Text;
            try
            {
                myCon.Open();
                ok = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                myCon.Close();
            }
            if (ok > 0)
            {
                return true;
            }
            return false;
        }

        public Permiso[] getPermisos()
        {
            Permiso[] permisos = null;
            dTable = new DataTable("permisos");
            try
            {
                myCon.Open();
                adapter = new SqlDataAdapter("select u.Usu, um.Id_mod, um.Alta, um.Baja, um.Modifica, um.Consulta, m.Descripcion from Usuarios_Modulos um join Usuario u on um.Usu = u.Usu join Modulo m on um.Id_mod = m.Id_mod", myCon);
                adapter.Fill(dTable);
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
                    permisos[i].nroModulo = (int)dTable.Rows[i]["Id_mod"];
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                myCon.Close();
            }
            return permisos;

        }

        public void actualizarPermisos(Permiso permiso)
        {
            string actualizaString;
            actualizaString = "UPDATE Usuarios_Modulos SET ";
            actualizaString += "Alta=@Alta, ";
            actualizaString += "Baja=@Baja, Modifica=@Modifica, Consulta=@Consulta ";
            actualizaString += "WHERE Usu=@Usuario and Id_mod=@Id_mod";
            SqlCommand cmd = new SqlCommand(actualizaString, myCon);
            cmd.Parameters.AddWithValue("@Usuario", permiso.Usuario);
            cmd.Parameters.AddWithValue("@Alta", permiso.Alta);
            cmd.Parameters.AddWithValue("@Baja", permiso.Baja);
            cmd.Parameters.AddWithValue("@Modifica", permiso.Modifica);
            cmd.Parameters.AddWithValue("@Consulta", permiso.Consulta);
            cmd.Parameters.AddWithValue("@Id_mod", permiso.nroModulo);
            try
            {
                myCon.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                myCon.Close();
            }
        }

        public bool agregarPermiso(string usuario, int modulo, bool alta, bool baja, bool modifica, bool consulta)
        {
            int ok=-1;
            string querry = "insert into Usuarios_Modulos (Usu, Id_mod, Alta, Baja, Modifica, Consulta) ";
            querry += "values ('" + usuario + "'," + modulo + "," + Convert.ToInt32(alta) + "," + Convert.ToInt32(baja) + "," + Convert.ToInt32(modifica) + "," + Convert.ToInt32(consulta) + ");";

            SqlCommand cmd = new SqlCommand(querry, myCon);
            cmd.CommandType = CommandType.Text;
            try
            {
                myCon.Open();
                ok = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                myCon.Close();
            }
            if (ok > 0)
            {
                return true;
            }
            return false;
        }

    }
}


        
       

