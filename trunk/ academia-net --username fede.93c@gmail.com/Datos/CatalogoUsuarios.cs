﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace CapaDeDatos
{
    public class CatalogoUsuarios
    {


        private static CatalogoUsuarios instancia;

        public static CatalogoUsuarios Instancia
        {
            get
            {
                if (instancia == null)
                {

                    instancia = new CatalogoUsuarios();
                }
                return instancia;
            }
        }






        SqlConnection myCon;
        SqlDataAdapter adapter;
        DataTable dTable;

        public CatalogoUsuarios()
        {
            myCon = ConnectionString.Conexion;
        }


        public Usuario[] getUsuarios()
        {
            Usuario[] usuarios;
            dTable = new DataTable("usuarios");
            myCon.Open();
            adapter = new SqlDataAdapter("select * from Usuario", myCon);
            adapter.Fill(dTable);
            myCon.Close();

            usuarios = new Usuario[dTable.Rows.Count];

            for (int i = 0; i < usuarios.Length; i++)
            {
                usuarios[i] = new Usuario();
                usuarios[i].Usu = dTable.Rows[i]["Usu"].ToString();
                usuarios[i].Clave = dTable.Rows[i]["Clave"].ToString();
                usuarios[i].Legajo = (int)dTable.Rows[i]["Legajo"];
            }

            return usuarios;
        }


        public bool eliminarUsuario(string usuario)
        {
            int ok;
            string querry = "delete from Usuario where Usuario.Usu = '" + usuario + "'";

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

        public bool agregaUsuario(int legajo, string usuario, string clave)
        {
            int ok;
            string querry = "insert into Usuario (Usu, Clave, Legajo) ";
            querry += "values ('" + usuario +"','" + clave + "'," + legajo + ");";

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

        public bool actualizarUsuarios(Usuario usuario)
        {
            int ok = -1;
            string actualizaString;
            actualizaString = "UPDATE Usuario SET Clave= '" + usuario.Clave + "', Legajo= '" + usuario.Legajo + "' where Usu='" + usuario.Usu+"'";
            SqlCommand cmd = new SqlCommand(actualizaString, myCon);
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