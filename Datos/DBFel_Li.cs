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
            //1.6.14
            // mov_1
            // mov_2
            // mov_3
            // mov_4
            cmd = new NpgsqlCommand("SELECT id, nombre, mov_1, mov_2 , mov_3, mov_4 FROM mov_adyacentes  " +
                " WHERE mov_3 IS NOT NULL " +
                " AND mov_4 IS NOT NULL " +
                " AND mov_2 IS NOT NULL ; ", conexion);
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
            // 2.10
            // mov_1
            // mov_2
          
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
            // 9.8.17.16
            // mov_1
            // mov_3
            // mov_4
            NpgsqlCommand DMS = new NpgsqlCommand("SELECT id, nombre, mov_1, mov_3, mov_4 FROM mov_adyacentes " +
                " WHERE mov_2 IS NULL " +
                " AND mov_4 IS NOT NULL ", conexion);

            NpgsqlDataReader lector = DMS.ExecuteReader();
            if (lector.HasRows)
            {
                while (lector.Read())
                {
                    adyacente = new ObjAdyacente
                    {
                        nombre = lector.GetString(1),
                        mov1 = lector.GetString(2),
                        mov_2 = "NULL",
                        mov_3 = lector.GetString(3),
                        mov_4 = lector.GetString(4)
                    };
                    listAdyacente.Add(adyacente);
                }
            }
            conexion.Close();


            conexion = Conexion.ConexionBD();
            conexion.Open();
            // 5.7.13.15
            // mov_1
            // mov_3
            NpgsqlCommand consulta = new NpgsqlCommand("SELECT id, nombre, mov_1, mov_3 FROM mov_adyacentes " +
                " WHERE mov_2 IS NULL " +
                " AND mov_4 IS NULL", conexion);

            NpgsqlDataReader reader = consulta.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    adyacente = new ObjAdyacente
                    {
                        nombre = reader.GetString(1),
                        mov1 = reader.GetString(2),
                        mov_2 = "NULL",
                        mov_3 = reader.GetString(3),
                        mov_4 = "NULL"
                    };
                    listAdyacente.Add(adyacente);
                }
            }
            conexion.Close();

            conexion = Conexion.ConexionBD();
            conexion.Open();
            // 3.4.11.12
            // mov_1
            // mov_2
            // mov_3
            NpgsqlCommand SCRIPT = new NpgsqlCommand("SELECT id, nombre, mov_1, mov_2, mov_3 FROM mov_adyacentes " +
                " WHERE mov_4 IS NULL " +
                " AND mov_2 IS NOT NULL " +
                " AND mov_3 IS NOT NULL; ", conexion);

            NpgsqlDataReader leerConsulta = SCRIPT.ExecuteReader();
            if (leerConsulta.HasRows)
            {
                while (leerConsulta.Read())
                {
                    adyacente = new ObjAdyacente
                    {
                        nombre = leerConsulta.GetString(1),
                        mov1 = leerConsulta.GetString(2),
                        mov_2 = leerConsulta.GetString(3),
                        mov_3 = leerConsulta.GetString(4),
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

            NpgsqlCommand re = new NpgsqlCommand("SELECT nombre, salto1, salto2 FROM mov_salto " +
                " WHERE salto3 IS  NULL " +
                " AND salto2 IS NOT NULL " +
                " AND salto4 IS  NULL; ", conexion);

            NpgsqlDataReader reader = re.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    saltos = new ObjSaltos
                    {
                        nombre = reader.GetString(0),
                        salto1 = reader.GetString(1),
                        salto2 = reader.GetString(2),
                        salto3 = "NULL",
                        salto4 = "NULL"
                    };
                    listSaltos.Add(saltos);
                }

            }
            conexion.Close();


            conexion = Conexion.ConexionBD();
            conexion.Open();

            NpgsqlCommand XE = new NpgsqlCommand("SELECT nombre, salto1, salto3 FROM mov_salto " +
                " WHERE salto2 IS NULL" +
                " AND salto4 IS NULL " +
                " AND salto3 IS NOT NULL", conexion);

            NpgsqlDataReader er = XE.ExecuteReader();
            if (er.HasRows)
            {
                while (er.Read())
                {
                    saltos = new ObjSaltos
                    {
                        nombre = er.GetString(0),
                        salto1 = er.GetString(1),
                        salto2 = "NULL",
                        salto3 = er.GetString(2),
                        salto4 = "NULL"
                    };
                    listSaltos.Add(saltos);
                }

            }
            conexion.Close();



            conexion = Conexion.ConexionBD();
            conexion.Open();

            NpgsqlCommand script = new NpgsqlCommand("SELECT nombre, salto1 FROM mov_salto " +
                " WHERE salto2 IS NULL" +
                " AND salto4 IS NULL " +
                " AND salto3 IS NULL", conexion);

            NpgsqlDataReader leer = script.ExecuteReader();
            if (leer.HasRows)
            {
                while (leer.Read())
                {
                    saltos = new ObjSaltos
                    {
                        nombre = leer.GetString(0),
                        salto1 = leer.GetString(1),
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

        /// <summary>
        /// Consultar datos para el grafico de pastel
        /// </summary>
        /// <returns></returns>
        public List<int> consultarResulto_Reinicio()
        {
            List<int> listaDatos = new List<int>();

            conexion = Conexion.ConexionBD();
            conexion.Open();

            cmd = new NpgsqlCommand("SELECT COUNT(estado) Cant FROM jugadas " +
                " GROUP BY estado;", conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    int cant = Convert.ToInt32(dr.GetString(0));
                    listaDatos.Add(cant);
                }

            }
            conexion.Close();
            return listaDatos;

        }

        public List<string> consultarNombreResueltos()
        {
            List<string> listaDatos = new List<string>();

            conexion = Conexion.ConexionBD();
            conexion.Open();

            cmd = new NpgsqlCommand("SELECT nombre_usuario, COUNT(estado) FROM jugadas " +
                " WHERE estado = 'Resuelto' " +
                " GROUP BY nombre_usuario " +
                " FETCH FIRST 3 ROWS ONLY", conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    string nomnbre = (dr.GetString(0));
                    listaDatos.Add(nomnbre);
                }

            }
            conexion.Close();
            return listaDatos;

        }

        public List<int> consultarCantResueltos()
        {
            List<int> listaDatos = new List<int>();

            conexion = Conexion.ConexionBD();
            conexion.Open();

            cmd = new NpgsqlCommand("SELECT nombre_usuario, COUNT(estado) FROM jugadas " +
                " WHERE estado = 'Resuelto' " +
                " GROUP BY nombre_usuario " +
                " FETCH FIRST 3 ROWS ONLY", conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    int cant = Convert.ToInt32(dr.GetString(1));
                    listaDatos.Add(cant);
                }

            }
            conexion.Close();
            return listaDatos;

        }

        public List<string> consultar_id()
        {
            List<string> listaDatos = new List<string>();

            conexion = Conexion.ConexionBD();
            conexion.Open();

            cmd = new NpgsqlCommand(" SELECT id, mov_adyacentes FROM jugadas " +
                " WHERE estado = 'Resuelto' " +
                "ORDER BY mov_adyacentes ASC " +
                " FETCH FIRST 3 ROWS ONLY", conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    string id = "Juego " + Convert.ToInt32(dr.GetString(0));
                    listaDatos.Add(id);
                }

            }
            conexion.Close();
            return listaDatos;
        }

        public List<int> consultar_movAdyacente()
        {
            List<int> listaDatos = new List<int>();

            conexion = Conexion.ConexionBD();
            conexion.Open();

            cmd = new NpgsqlCommand(" SELECT id, mov_adyacentes FROM jugadas " +
                " WHERE estado = 'Resuelto' " +
                "ORDER BY mov_adyacentes ASC " +
                " FETCH FIRST 3 ROWS ONLY", conexion);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    int movivimiento_adyacente = Convert.ToInt32(dr.GetString(1));
                    listaDatos.Add(movivimiento_adyacente);
                }

            }
            conexion.Close();
            return listaDatos;
        }


        public void Insertar(ObjFelLi felLi)
        {
            conexion = Conexion.ConexionBD();
            conexion.Open();
            cmd = new NpgsqlCommand("INSERT INTO public.jugadas(nombre_usuario, fecha, mov_adyacentes, cant_saltos, estado) " +
                " VALUES( " +
                "'" + felLi.nombre_jugador + "',"+
                "'"+ felLi.fecha + "'," +
                felLi.mov_adyacente + "," +
                + felLi.cant_saltos +"," +
                "'" + felLi.estado + "');", conexion);
            
            cmd.ExecuteNonQuery();
            conexion.Close();
        }




    }
}
