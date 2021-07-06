using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Objetos;

namespace Datos
{
    public class DBReportes
    {
        static NpgsqlConnection conexion;
        static NpgsqlCommand cmd;

        public List<ObjUsuarios> llenar_cbUsuario()
        {
            List<ObjUsuarios> usuarios = new List<ObjUsuarios>();
            conexion = Conexion.ConexionBD();
            conexion.Open();
            cmd = new NpgsqlCommand("SELECT id, nombre_usuario FROM public.usuarios " +
                " ORDER BY id ASC ", conexion);

            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ObjUsuarios user = new ObjUsuarios()
                    {
                        id = Convert.ToInt32(dr.GetString(0)),
                        nombre_jugador = dr.GetString(1)
                    };
                    usuarios.Add(user);
                }
            }
            conexion.Close();
            return usuarios;

        }

        public List<ObjRep1> reporte1(string nombre)
        {
            List<ObjRep1> reporte = new List<ObjRep1>();
            conexion = Conexion.ConexionBD();
            conexion.Open();
            cmd = new NpgsqlCommand("SELECT nombre_usuario, fecha, mov_adyacentes FROM jugadas " +
                " WHERE nombre_usuario = '" + nombre + "'" +
                " AND estado = 'Resuelto' " +
                " ORDER BY mov_adyacentes ASC " +
                " FETCH FIRST 1 ROWS ONLY", conexion);

            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ObjRep1 rep1 = new ObjRep1()
                    {
                        nombre = dr.GetString(0),
                        fecha = dr.GetDateTime(1),
                        mov_Adyacentes = Convert.ToInt32(dr.GetString(2))
                    };
                    reporte.Add(rep1);
                }
            }
            conexion.Close();
            return reporte;
        }

        public List<ObjRep2_3> reporte2()
        {
            List<ObjRep2_3> reporte = new List<ObjRep2_3>();
            conexion = Conexion.ConexionBD();
            conexion.Open();
            cmd = new NpgsqlCommand("SELECT nombre_usuario, COUNT(estado) FROM jugadas " +
                " WHERE estado = 'Resuelto' " +
                " GROUP BY nombre_usuario", conexion);

            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ObjRep2_3 rep2 = new ObjRep2_3()
                    {
                        nombre = dr.GetString(0),
                        cant = Convert.ToInt32(dr.GetString(1))
                    };
                    reporte.Add(rep2);
                }
            }
            conexion.Close();
            return reporte;
        }

        public List<ObjRep2_3> reporte3(string nombre)
        {
            List<ObjRep2_3> reporte = new List<ObjRep2_3>();
            conexion = Conexion.ConexionBD();
            conexion.Open();
            cmd = new NpgsqlCommand("SELECT nombre_usuario, COUNT(estado) FROM jugadas " +
                " WHERE estado = 'Reinicio' " +
                "AND nombre_usuario = '" + nombre + "'" +
                "GROUP BY nombre_usuario", conexion);

            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ObjRep2_3 rep2 = new ObjRep2_3()
                    {
                        nombre = dr.GetString(0),
                        cant = Convert.ToInt32(dr.GetString(1))
                    };
                    reporte.Add(rep2);
                }
            }
            conexion.Close();
            return reporte;
        }

    }
}
