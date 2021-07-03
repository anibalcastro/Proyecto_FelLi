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

    }
}
