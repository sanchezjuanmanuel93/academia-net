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


        private static CatalogoPersonas instancia;

        public static CatalogoPersonas Instancia
        {
            get
            {
                if (instancia == null)
                {

                    instancia = new CatalogoPersonas();
                }
                return instancia;
            }
        }



        SqlConnection myCon;
        SqlDataAdapter adapter;
        DataTable dTable;

        public CatalogoPersonas()
        {
            myCon = ConnectionString.Conexion;
        }

        public Persona getPersona(string usuario, string contraseña)
        {
            try
            {
                dTable = new DataTable("personas");
                myCon.Open();
                adapter = new SqlDataAdapter("SELECT * from usuario join persona on usuario.Legajo = persona.Legajo WHERE Usu = '" + usuario + "' and Clave = '" + contraseña + "';", myCon);
                adapter.Fill(dTable);
                if (dTable.Rows.Count != 0)
                {
                    return completarPersona(dTable.Rows[0], true);
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
            return null; 
        }

        public List<TipoPersona> getTiposPersona()
        {
            try
            {
                List<TipoPersona> tipos = new List<TipoPersona>();
                dTable = new DataTable("tiposPersona");
                myCon.Open();
                adapter = new SqlDataAdapter("select * from Tipo_Persona", myCon);
                adapter.Fill(dTable);
                
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
            }
            catch(Exception e)
            {
                   Console.WriteLine(e.Message); 
            }
            finally
            {
                myCon.Close();
            }            
            return null;
        }

        public List<Persona> getPersonasSinUsuario()
        {
            try
            {
                List<Persona> personas = new List<Persona>();
                dTable = new DataTable("personas");
                myCon.Open();
                adapter = new SqlDataAdapter("select * from Persona except select p.Legajo, p.Nombre, p.Apellido, p.Email, p.Telefono, p.Tipo from Usuario u right join Persona p on u.Legajo = p.Legajo where u.Usu is not null", myCon);
                adapter.Fill(dTable);

                if (dTable.Rows.Count != 0)
                {
                    foreach (DataRow row in dTable.Rows)
                    {
                        personas.Add(completarPersona(row, false));
                    }
                    return personas;
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
            return null;
        }

        public List<Persona> getPersonas()
        {
            try
            {
                List<Persona> personas = new List<Persona>();
                dTable = new DataTable("personas");
                myCon.Open();
                adapter = new SqlDataAdapter("select * from Persona join Tipo_Persona on persona.Tipo = Tipo_Persona.Id_tipo ", myCon);
                adapter.Fill(dTable);
                if (dTable.Rows.Count != 0)
                {
                    foreach (DataRow row in dTable.Rows)
                    {
                        personas.Add(completarPersona(row, false));
                    }
                    return personas;
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
            try
            {
                myCon.Open();
                ok = cmd.ExecuteNonQuery();
                if (ok > 0)
                {
                    return true;
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
            
            return false;
        }

        public bool agregaPersona(string legajo, string nombre, string apellido, string email, string telefono, int tipo)
        {
            int ok;
            string querry = "insert into Persona (Legajo, Nombre, Apellido, Email, Telefono, Tipo) ";
            querry += "values (" + legajo + ",'" + nombre + "','" + apellido + "','" + email + "','" + telefono + "'," + tipo + ");";
            try
            {
                SqlCommand cmd = new SqlCommand(querry, myCon);
                cmd.CommandType = CommandType.Text;
                myCon.Open();
                ok = cmd.ExecuteNonQuery();
                if (ok > 0)
                {
                    return true;
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
            
            return false;
        }


        public void actualizarPersonas(Persona persona)
        {
            string actualizaString;
            actualizaString = "UPDATE Persona SET ";
            actualizaString += "Telefono=@Telefono, ";
            actualizaString += "Nombre=@Nombre, Apellido=@Apellido, Email=@Email ";
            actualizaString += "WHERE Legajo=@Legajo";
            SqlCommand cmd = new SqlCommand(actualizaString, myCon);
            cmd.Parameters.AddWithValue("@Legajo", persona.Legajo);
            cmd.Parameters.AddWithValue("@Telefono", persona.Telefono);
            cmd.Parameters.AddWithValue("@Nombre", persona.Nombre);
            cmd.Parameters.AddWithValue("@Apellido", persona.Apellido);
            cmd.Parameters.AddWithValue("@Email", persona.Email);
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

    }
}
