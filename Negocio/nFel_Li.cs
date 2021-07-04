using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Objetos;
using Datos;

namespace Negocio
{
    public class nFel_Li
    {
        List<ObjSaltos> saltos = new List<ObjSaltos>();
        List<ObjAdyacente> adyacente = new List<ObjAdyacente>();
        Datos.DBFel_Li fel_Li;

        public nFel_Li()
        {
            adyacente = new Datos.DBFel_Li().llenarListaAdyacente1();
            saltos = new Datos.DBFel_Li().llenarListaSaltos();
        }

        public bool validarMovimientoAdyacente(string seleccion, string cambio)
        {
            bool validar = false;
            for (int x = 0; x < adyacente.Count; x++)
            {
                if (adyacente[x].nombre.Equals(seleccion))
                {
                    if (adyacente[x].mov1.Equals(cambio) ||
                        adyacente[x].mov_2.Equals(cambio) ||
                        adyacente[x].mov_3.Equals(cambio) ||
                        adyacente[x].mov_4.Equals(cambio))
                    {
                        validar = true;
                        break;
                    }
                    else
                    {
                        validar = false;
                        break;
                    }
                }
            }
            return validar;
        }

        public bool validarMovimientoSalto(string seleccion, string cambio)
        {
            bool validar = false;

            for (int x = 0; x < saltos.Count; x++)
            {
                if (saltos[x].nombre.Equals(seleccion))
                {
                    if (saltos[x].salto1.Equals(cambio) ||
                        saltos[x].salto2.Equals(cambio) ||
                        saltos[x].salto3.Equals(cambio) ||
                        saltos[x].salto4.Equals(cambio))
                    {
                        validar = true;
                        break;
                    }
                    else
                    {
                        validar = false;
                        break;
                    }
                }
            }
            return validar;
        }

        public void insertarDatos(ObjFelLi objFelLi)
        {
            new Datos.DBFel_Li().Insertar(objFelLi);
        }
    }
}
