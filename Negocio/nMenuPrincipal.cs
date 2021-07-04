using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Objetos;
using Datos;

namespace Negocio
{
     public class nMenuPrincipal
    {
        public bool validarExistenciaUsuario(string usuario)
        {
            bool validar = new Datos.DBUsuarios().existenciaUsuario(usuario);

            if (!validar)
            {
                new Datos.DBUsuarios().InsertarUsuarios(usuario);
                return true;
            }
            return true;
        }

        public List<int> listPastel()
        {
            return new Datos.DBFel_Li().consultarResulto_Reinicio();
        }

        public List<string> usuarios()
        {
            return new Datos.DBFel_Li().consultarNombreResueltos();
        }

        public List<int> resultados_usuarios()
        {
            return new Datos.DBFel_Li().consultarCantResueltos();
        }
        
        public List<string> consultar_id()
        {
            return new Datos.DBFel_Li().consultar_id();
        }

        public List<int> movimiento_adyacente()
        {
            return new Datos.DBFel_Li().consultar_movAdyacente();
        }

    }


}
