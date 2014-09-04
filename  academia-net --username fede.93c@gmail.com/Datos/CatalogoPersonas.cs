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
            dTable = new DataTable("personas");
            myCon.Open();
            adapter = new SqlDataAdapter("SELECT * from usuario join persona on usuario.Legajo = persona.Legajo WHERE Usu = '" + usuario + "' and Clave = '" + contraseña + "';", myCon);
            adapter.Fill(dTable);
            myCon.Close();
            if (dTable.Rows.Count != 0)
            {
                return completarPersona(dTable.Rows[0], true);
            }
            return null;
        }

        public List<TipoPersona> getTiposPersona()
        {
            List<TipoPersona> tipos = new List<TipoPersona>();
            dTable = new DataTable("tiposPersona");
            myCon.Open();
            adapter = new SqlDataAdapter("select * from Tipo_Persona", myCon);
            adapter.Fill(dTable);
            myCon.Close();
            if (dTable.Rows.Count != 0)
            {
                foreach (DataRow row in dTable.Rows)
                {
                    TipoPersona tipo = new TipoPersona();
                    tipo.Descripcion = row["Descripcion"].ToString();
                    tipo.tipo = (int)row["Id_tipo"];
                    tipos.Add(tipo);
                }
                return tipos;
            }
            return null;
        }

        public List<Persona> getPersonasSinUsuario()
        {
            List<Persona> personas = new List<Persona>();
            dTable = new DataTable("personas");
            myCon.Open();
            adapter = new SqlDataAdapter("select * from Persona except select p.Legajo, p.Nombre, p.Apellido, p.Email, p.Telefono, p.Tipo from Usuario u right join Persona p on u.Legajo = p.Legajo where u.Usu is not null", myCon);
            adapter.Fill(dTable);
            myCon.Close();
            if (dTable.Rows.Count != 0)
            {
                foreach (DataRow row in dTable.Rows)
                {
                    personas.Add(completarPersona(row, false));
                }
                return personas;
            }
            return null;
        }

        public List<Persona> getPersonas()
        {
            List<Persona> personas = new List<Persona>();
            dTable = new DataTable("personas");
            myCon.Open();
            adapter = new SqlDataAdapter("select * from Persona join Tipo_Persona on persona.Tipo = Tipo_Persona.Id_tipo ", myCon);
            adapter.Fill(dTable);
            myCon.Close();
            if (dTable.Rows.Count != 0)
            {
                foreach (DataRow row in dTable.Rows)
                {
                    personas.Add(completarPersona(row, false));
                }
                return personas;
            }
            return null;
        }

        Persona completarPersona(DataRow dRow, bool usu)
        {
            Persona persona = new Persona();
            persona.Legajo = dRow["Legajo"].ToString();
            persona.Nombre = dRow["nombre"].ToString();
            persona.Apellido = dRow["apellido"].ToString();
            persona.Telefono = dRow["telefono"].ToString();
            persona.Email = dRow["email"].ToString();
            persona.Tipo = (int)dRow["Tipo"];
           

            if (usu)
            {
                persona.Usuario = dRow["usu"].ToString();
            }
            return persona;
        }

        public bool eliminarPersona(string legajo)
        {
            int ok;
            string querry = "delete from Persona where Persona.Legajo = " + legajo;

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

        public bool agregaPersona(string legajo, string nombre, string apellido, string email, string telefono, int tipo)
        {
            int ok;
            string querry = "insert into Persona (Legajo, Nombre, Apellido, Email, Telefono, Tipo) ";
            querry += "values (" + legajo + ",'" + nombre + "','" + apellido + "','" + email + "','" + telefono + "'," + tipo + ");";

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
