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
        string connectionString = ConnectionString.connectionString;

        SqlConnection myCon;
        SqlDataAdapter adapter;
        DataTable dTable;

        
        public CatalogoMaterias()
        {
            myCon = new SqlConnection(connectionString);
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
                materia.Descripcion = row["descripcion"].ToString();
                materias.Add(materia);
            }

            return materias;

        }

    }
}
