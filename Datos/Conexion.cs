using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Datos
{
    public class Conexion
    {
        static NpgsqlConnection conexion;

        public static NpgsqlConnection ConexionBD()
        {
            string servidor = "localhost";
            int puerto = 5432;
            string usuario = "postgres";
            string clave = "AC1221";
            string baseDatos = "Fel-Li";

            string cadenaConexion = "Server= " + servidor + ";" + "Port=" + puerto + ";" +
                "User Id=" + usuario + ";" + "Password=" + clave + ";" + "Database=" + baseDatos;

            return conexion = new NpgsqlConnection(cadenaConexion);
        }
    }
}
