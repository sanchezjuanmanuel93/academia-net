using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlClient;
namespace CapaDeDatos
{
    public class CatalogoMaterias
    {


        private static CatalogoMaterias instancia;

        public static CatalogoMaterias Instancia
        {
            get
            {
                if (instancia == null)
                {

                    instancia = new CatalogoMaterias();
                }
                return instancia;
            }
        }



        SqlConnection myCon;
        SqlDataAdapter adapter;
        DataTable dTable;

        
        public CatalogoMaterias()
        {
            myCon = ConnectionString.Conexion;
        }

        public List<Materias> getMaterias()
        {
            List<Materias> materias = new List<Materias>();
            dTable = new DataTable("Materias");
            myCon.Open();
            adapter = new SqlDataAdapter("Select * from Materia", myCon);
            adapter.Fill(dTable);
            myCon.Close();

            foreach (DataRow row in dTable.Rows)
            {
                
                Materias materia = new Materias();
                materia.nroMateria = (int)row["id_mat"];
                materia.Nombre = row["descripcion"].ToString();
                materias.Add(materia);
            }

            return materias;

        }

        public bool agregarMateria(string numero, string nombre)
        {
            int ok;
            string querry = "insert into Materia (Id_mat, Descripcion) ";
            querry += "values (" + int.Parse(numero) + ",'" + nombre + "');";

            SqlCommand cmd = new SqlCommand(querry, myCon);
            cmd.CommandType = CommandType.Text;
            myCon.Open();
            ok = cmd.ExecuteNonQuery();
            myCon.Close();

            if (ok > 0)
            {
                return true;
            }
            return false;
        }

        public bool eliminarMateria(string nombre)
        {
            int ok;
            string querry = "delete from Materia where Materia.Descripcion = " + nombre;

            SqlCommand cmd = new SqlCommand(querry, myCon);
            cmd.CommandType = CommandType.Text;
            myCon.Open();
            ok = cmd.ExecuteNonQuery();
            myCon.Close();

            if (ok > 0)
            {
                return true;
            }
            return false;
        }

    }
}
