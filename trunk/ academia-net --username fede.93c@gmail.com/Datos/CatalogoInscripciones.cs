using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlClient;


namespace CapaDeDatos
{

    public class CatalogoInscripciones
    {


        private static CatalogoInscripciones instancia;

        public static CatalogoInscripciones Instancia
        {
            get
            {
                if (instancia == null)
                {
                    
                    instancia = new CatalogoInscripciones();
                }
                return instancia;
            }
        }

        SqlConnection myCon;
        SqlDataAdapter adapter;
        DataTable dTable;

        public CatalogoInscripciones()
        {
            myCon = ConnectionString.Conexion;
        }

        public List<Inscripciones> getInscripciones()
        {
            List<Inscripciones> Inscripciones = new List<Inscripciones>();
            dTable = new DataTable("Inscripciones");
            myCon.Open();
            adapter = new SqlDataAdapter("select * from Personas_Materias pm join Materia m on pm.id_mat = m.id_mat join Persona p on p.legajo = pm.legajo", myCon);
            adapter.Fill(dTable);
            myCon.Close();
            if (dTable.Rows.Count != 0)
            {
                foreach (DataRow row in dTable.Rows)
                {
                    Inscripciones inscripcion = new Inscripciones();
                    inscripcion.Legajo = (int)row["Legajo"];
                    inscripcion.nroMateria = (int)row["id_mat"];
                    inscripcion.fecha = (DateTime)row["fecha"];
                    inscripcion.NombreMateria = row["Descripcion"].ToString();
                    inscripcion.Nombre = row["Nombre"].ToString();
                    inscripcion.Apellido = row["apellido"].ToString();
                    Inscripciones.Add(inscripcion);
                }
                return Inscripciones;
            }
            return null;
        }

        public List<Inscripciones> getInscripciones(string legajo)
        {
            List<Inscripciones> Inscripciones = new List<Inscripciones>();
            dTable = new DataTable("Inscripciones");
            myCon.Open();
            adapter = new SqlDataAdapter("select * from Personas_Materias pm join Materia m on pm.id_mat = m.id_mat join Persona p on p.legajo = pm.legajo where p.legajo ='" + legajo + "'", myCon);
            adapter.Fill(dTable);
            myCon.Close();
            if (dTable.Rows.Count != 0)
            {
                foreach (DataRow row in dTable.Rows)
                {
                    Inscripciones inscripcion = new Inscripciones();
                    inscripcion.Legajo = (int)row["Legajo"];
                    inscripcion.nroMateria = (int)row["id_mat"];
                    inscripcion.fecha = (DateTime)row["fecha"];
                    inscripcion.NombreMateria = row["Descripcion"].ToString();
                    inscripcion.Nombre = row["Nombre"].ToString();
                    inscripcion.Apellido = row["apellido"].ToString();
                    Inscripciones.Add(inscripcion);
                }
                return Inscripciones;
            }
            return null;
        }

        public bool eliminarInscripcion(string legajo, string id_mat)
        {
            int ok;
            string querry = "delete from Personas_Materias where Legajo = '" + legajo + "' and Id_mat =" + id_mat;

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

        public bool agregaInscripcion(string legajo, string id_mat, string fecha)
        {
            int ok;
            string querry = "insert into Personas_Materias (Legajo, Id_mat, fecha)";
            querry += "values (" + legajo + ",'" + id_mat + "','" + fecha + "');";

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


        public bool actualizarPersonas(Inscripciones inscripcion)
        {
            int ok = -1;
            string actualizaString;
            actualizaString = "UPDATE Personas_Materias SET ";
            actualizaString += "fecha=@fecha, ";
            actualizaString += "where Persona.Legajo = '" + inscripcion.Legajo + "' and Materia.Id_mat =" + inscripcion.nroMateria;
            SqlCommand cmd = new SqlCommand(actualizaString, myCon);
            cmd.Parameters.AddWithValue("@fecha", inscripcion.fecha);
            myCon.Open();
            ok =cmd.ExecuteNonQuery();
            myCon.Close();
            if (ok > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
