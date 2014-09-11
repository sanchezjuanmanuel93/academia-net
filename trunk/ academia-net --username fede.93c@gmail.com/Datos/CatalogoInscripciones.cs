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
    }
}
