using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace CapaDeDatos
{
    public class CatalogoPersonas
    {
        string connectionString = "Data Source=FEDEE-PC\\SQLSERVER08R2;Initial Catalog=Academia;Integrated Security=True";
        
        SqlConnection myCon;
        SqlDataAdapter adapter;
        DataTable dTable;

        public CatalogoPersonas()
        {
            myCon = new SqlConnection(connectionString);
        }

        public Persona getPersona(string usuario, string contraseña)
        {
            dTable = new DataTable("usuarios");
            myCon.Open();
            adapter = new SqlDataAdapter("SELECT * from usuario join persona on usuario.Legajo = persona.Legajo WHERE Usu = '" + usuario + "' and Clave = '" + contraseña + "';", myCon);
            adapter.Fill(dTable);
            myCon.Close();
            if (dTable.Rows.Count != 0)
            {
                return completarPersona(dTable.Rows[0]);
            }
            return null;
        }

        Persona completarPersona(DataRow dRow)
        {
            Persona persona = new Persona();
            persona.Legajo = dRow["legajo"].ToString();
            persona.Nombre = dRow["nombre"].ToString();
            persona.Apellido = dRow["apellido"].ToString();
            persona.Telefono = dRow["telefono"].ToString();
            persona.Email = dRow["email"].ToString();
            persona.Usuario = dRow["Usu"].ToString();
            return persona;
        }

        public void agregarPersona(Persona persona)
        {
            //myCon.Open();
            //SqlCommand q = new SqlCommand("INSERT INTO persona VALUES (" + persona.cadena + ");", myCon);
            //q.ExecuteNonQuery();
            //myCon.Close();
        }
    }
}
