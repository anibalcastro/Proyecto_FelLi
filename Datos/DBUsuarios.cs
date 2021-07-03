using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Objetos;

namespace Datos
{
    public class DBUsuarios
    {
        static NpgsqlConnection conexion;
        static NpgsqlCommand cmd;
        Objetos.ObjUsuarios usuario;


        public void InsertarUsuarios(string usuario)
        {
            conexion = Conexion.ConexionBD();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT INTO usuarios (nombre_usuario)" +
                "VALUES ("
                + "'" + usuario + "');", conexion);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public bool existenciaUsuario(string nombre)
        {
            List<ObjUsuarios> listaUsuarios = new List<ObjUsuarios>();

            conexion = Conexion.ConexionBD();
            conexion.Open();
            cmd = new NpgsqlCommand("SELECT id FROM usuarios WHERE  nombre_usuario= '" + nombre + "';", conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ObjUsuarios usua = new ObjUsuarios()
                    {
                        id = dr.GetInt32(0),

                    };
                    listaUsuarios.Add(usua);
                }

            }
            if (listaUsuarios.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
            conexion.Close();

        }
    }
}
