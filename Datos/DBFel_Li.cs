using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Objetos;

namespace Datos
{
     public class DBFel_Li
    {
        static NpgsqlConnection conexion;
        static NpgsqlCommand cmd;
        static NpgsqlCommand cns;
        Objetos.ObjAdyacente adyacente;
        Objetos.ObjSaltos saltos;

        public List<ObjAdyacente> llenarListaAdyacente1()
        {
            List<ObjAdyacente> listAdyacente = new List<ObjAdyacente>();

            conexion = Conexion.ConexionBD();
            conexion.Open();

            cmd = new NpgsqlCommand("SELECT id, nombre, mov_1, mov_2 , mov_3, mov_4 FROM mov_adyacentes " +
                " WHERE mov_3 IS NOT NULL " +
                " AND mov_4 IS NOT NULL; ", conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    adyacente = new ObjAdyacente
                    {
                        nombre = dr.GetString(1),
                        mov1 = dr.GetString(2),
                        mov_2 = dr.GetString(3),
                        mov_3 = dr.GetString(4),
                        mov_4 = dr.GetString(5),
                    };
                    listAdyacente.Add(adyacente);
                }

            }
            conexion.Close();

            conexion = Conexion.ConexionBD();
            conexion.Open();

            cns = new NpgsqlCommand("SELECT id, nombre, mov_1, mov_2  FROM mov_adyacentes " +
                " WHERE mov_3 IS NULL " +
                " AND mov_4 IS NULL; ", conexion);

            NpgsqlDataReader RD = cns.ExecuteReader();
            if (RD.HasRows)
            {
                while (RD.Read())
                {
                    adyacente = new ObjAdyacente
                    {
                        nombre = RD.GetString(1),
                        mov1 = RD.GetString(2),
                        mov_2 = RD.GetString(3),
                        mov_3 = "NULL",
                        mov_4 = "NULL"
                    };
                    listAdyacente.Add(adyacente);
                }
            }

            conexion.Close();

            conexion = Conexion.ConexionBD();
            conexion.Open();

            NpgsqlCommand DMS = new NpgsqlCommand("SELECT id, nombre, mov_1, mov_2, mov_3  FROM mov_adyacentes  " +
                " WHERE mov_4 IS NULL " +
                " AND mov_3 IS NOT NULL; ", conexion);

            NpgsqlDataReader lector = DMS.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    adyacente = new ObjAdyacente
                    {
                        nombre = lector.GetString(1),
                        mov1 = lector.GetString(2),
                        mov_2 = lector.GetString(3),
                        mov_3 = lector.GetString(4),
                        mov_4 = "NULL"
                    };
                    listAdyacente.Add(adyacente);
                }
            }
            conexion.Close();
            return listAdyacente;
        }


        public List<ObjSaltos> llenarListaSaltos()
        {
            List<ObjSaltos> listSaltos = new List<ObjSaltos>();

            conexion = Conexion.ConexionBD();
            conexion.Open();

            cmd = new NpgsqlCommand("SELECT id, nombre, salto1, salto2, salto3, salto4 " +
                " FROM public.mov_salto " +
                " WHERE salto3 IS NOT NULL " +
                " AND salto4 IS NOT NULL;", conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    saltos = new ObjSaltos
                    {
                        nombre = dr.GetString(1),
                        salto1 = dr.GetString(2),
                        salto2 = dr.GetString(3),
                        salto3 = dr.GetString(4),
                        salto4 = dr.GetString(5)
                    };
                    listSaltos.Add(saltos);
                }

            }
            conexion.Close();

            conexion = Conexion.ConexionBD();
            conexion.Open();

            NpgsqlCommand re = new NpgsqlCommand("SELECT id, nombre, salto1, salto2, salto3, salto4 " +
                " FROM public.mov_salto " +
                " WHERE salto3 IS NULL " +
                " AND salto4 IS NULL" +
                " AND salto2 IS NOT NULL;", conexion);

            NpgsqlDataReader reader = re.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    saltos = new ObjSaltos
                    {
                        nombre = reader.GetString(1),
                        salto1 = reader.GetString(2),
                        salto2 = reader.GetString(3),
                        salto3 = "NULL",
                        salto4 = "NULL"
                    };
                    listSaltos.Add(saltos);
                }

            }
            conexion.Close();


            conexion = Conexion.ConexionBD();
            conexion.Open();

            NpgsqlCommand XE = new NpgsqlCommand("SELECT id, nombre, salto1 " +
                " FROM public.mov_salto " +
                " WHERE salto2 IS NULL " +
                " AND SALTO3 IS NULL;", conexion);

            NpgsqlDataReader er = XE.ExecuteReader();
            if (er.HasRows)
            {
                while (er.Read())
                {
                    saltos = new ObjSaltos
                    {
                        nombre = er.GetString(1),
                        salto1 = er.GetString(2),
                        salto2 = "NULL",
                        salto3 = "NULL",
                        salto4 = "NULL"
                    };
                    listSaltos.Add(saltos);
                }

            }
            conexion.Close();


            return listSaltos;
        }

    }
}
