using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Objetos;
using Datos;

namespace Negocio
{
   public class nReportes
    {
        public List<ObjUsuarios> cb_llenar()
        {
            return new Datos.DBReportes().llenar_cbUsuario();
        }

        public List<ObjRep1> reporte1(string nombre)
        {
            return new Datos.DBReportes().reporte1(nombre);
        }

        public List<ObjRep2_3> reporte2()
        {
            return new Datos.DBReportes().reporte2();
        }

        public List<ObjRep2_3> reporte3(string nombre)
        {
            return new Datos.DBReportes().reporte3(nombre);
        }
    }
}
