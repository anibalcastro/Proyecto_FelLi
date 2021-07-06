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
        List<string> panel_fichas_azules = new List<string>{ "A_8", "A_7", "A_6", "A_5", "A_4", "A_3", "A_2", "A_1" };
        List<string> panel_fichas_rojas = new List<string> { "B_8", "B_7", "B_6", "B_5", "B_4", "B_3", "B_2", "B_1" };
        List<string> panel_fichas_vacio = new List<string> { "m_0"};


        Datos.DBFel_Li fel_Li;

        /// <summary>
        /// Se llenan las listas que viene de base de datos
        /// </summary>
        public nFel_Li()
        {
            adyacente = new Datos.DBFel_Li().llenarListaAdyacente1();
            saltos = new Datos.DBFel_Li().llenarListaSaltos();
        }

        /// <summary>
        /// Validaciones si el movimiento fue adyacente
        /// por medio de la seleccion de la ficha
        /// el cambio de la ficha
        /// y la imagen
        /// </summary>
        /// <param name="seleccion"></param>
        /// <param name="cambio"></param>
        /// <param name="imagen"></param>
        /// <returns></returns>
        public bool validarAdyacente(string seleccion, string cambio, string imagen)
        {
            bool valido = false;
            string imagen_ficha_azul = "ficha-de-poker.png";
            string imagen_ficha_roja = "juego.png";

            if (panel_fichas_azules.Contains(seleccion))
            {
                if (imagen.Equals(imagen_ficha_azul))
                {
                    for (int x = 0; x < adyacente.Count; x++)
                    {
                        if (seleccion.Equals(adyacente[x].nombre))
                        {
                            if (cambio.Equals(adyacente[x].mov1) || cambio.Equals(adyacente[x].mov_2))
                            {
                                valido = true;
                                break;
                            }
                            else
                            {
                                valido = false;
                                break;
                            }
                        }
                    }
                }
                else if (imagen.Equals(imagen_ficha_roja))
                {
                    for (int x = 0; x < adyacente.Count; x++)
                    {
                        if (seleccion.Equals(adyacente[x].nombre))
                        {
                            if (cambio.Equals(adyacente[x].mov_3) || cambio.Equals(adyacente[x].mov_4))
                            {
                                valido = true;
                                break;
                            }
                            else
                            {
                                valido = false;
                                break;
                            }
                        }
                    }
                }        
            }
            else if (panel_fichas_rojas.Contains(seleccion))
            {
                if (imagen.Equals(imagen_ficha_roja))
                {
                    for (int x = 0; x < adyacente.Count; x++)
                    {
                        if (seleccion.Equals(adyacente[x].nombre))
                        {
                            if (cambio.Equals(adyacente[x].mov1) || cambio.Equals(adyacente[x].mov_2))
                            {
                                valido = true;
                                break;
                            }
                            else
                            {
                                valido = false;
                                break;
                            }
                        }
                    }
                }
                else if (imagen.Equals(imagen_ficha_azul))
                {
                    for (int x = 0; x < adyacente.Count; x++)
                    {
                        if (seleccion.Equals(adyacente[x].nombre))
                        {
                            if (cambio.Equals(adyacente[x].mov_3) || cambio.Equals(adyacente[x].mov_4))
                            {
                                valido = true;
                                break;
                            }
                            else
                            {
                                valido = false;
                                break;
                            }
                        }
                    }
                }
            }
            else if (panel_fichas_vacio.Contains(seleccion))
            {
                for (int x = 0; x< adyacente.Count; x++)
                {
                    if (seleccion.Equals(adyacente[x].nombre))
                    {
                        if (cambio.Equals(adyacente[x].mov1) ||
                            cambio.Equals(adyacente[x].mov_2) ||
                            cambio.Equals(adyacente[x].mov_3) ||
                            cambio.Equals(adyacente[x].mov_4))
                        {
                            valido = true;
                        } 
                        else
                        {
                            valido = false;
                        }
                    }
                }
            }

            return valido;
        }

        /// <summary>
        /// Validaciones si el movimiento fue con salto
        /// </summary>
        /// <param name="seleccion"></param>
        /// <param name="cambio"></param>
        /// <param name="imagen"></param>
        /// <returns></returns>
        public bool validarSalto(string seleccion, string cambio, string imagen)
        {
            bool valido = false;
            string imagen_ficha_azul = "ficha-de-poker.png";
            string imagen_ficha_roja = "juego.png";

            if (panel_fichas_azules.Contains(seleccion))
            {
                if (imagen.Equals(imagen_ficha_azul))
                {
                    for (int x = 0; x < saltos.Count; x++)
                    {
                        if (seleccion.Equals(saltos[x].nombre))
                        {
                            if (cambio.Equals(saltos[x].salto1) || cambio.Equals(saltos[x].salto2))
                            {
                                valido = true;
                                break;
                            }
                            else
                            {
                                valido = false;
                                break;
                            }
                                
                        }
                    }
                } 
                else if (imagen.Equals(imagen_ficha_roja))
                {
                    for (int x = 0; x < saltos.Count; x++)
                    {
                        if (seleccion.Equals(saltos[x].nombre))
                        {
                            if (cambio.Equals(saltos[x].salto3) || cambio.Equals(saltos[x].salto4))
                            {
                                valido = true;
                                break;
                            }
                            else
                            {
                                valido = false;
                                break;
                            }

                        }
                    }
                }
                    
            }
            else if (panel_fichas_rojas.Contains(seleccion))
            {
                if (imagen.Equals(imagen_ficha_roja))
                {
                    for (int x = 0; x < saltos.Count; x++)
                    {
                        if (seleccion.Equals(saltos[x].nombre))
                        {
                            if (cambio.Equals(saltos[x].salto1) || cambio.Equals(saltos[x].salto2))
                            {
                                valido = true;
                                break;
                            }
                            else
                            {
                                valido = false;
                                break;
                            }

                        }
                    }
                }
                else if (imagen.Equals(imagen_ficha_azul))
                {
                    for (int x = 0; x < saltos.Count; x++)
                    {
                        if (seleccion.Equals(saltos[x].nombre))
                        {
                            if (cambio.Equals(saltos[x].salto3) || cambio.Equals(saltos[x].salto4))
                            {
                                valido = true;
                                break;
                            }
                            else
                            {
                                valido = false;
                                break;
                            }

                        }
                    }
                }
            }
            else if (panel_fichas_vacio.Contains(seleccion))
            {
                for (int x = 0; x < saltos.Count; x++)
                {
                    if (saltos[x].nombre.Equals(seleccion))
                    {
                        if (saltos[x].salto1.Equals(cambio) ||
                            saltos[x].salto2.Equals(cambio) ||
                            saltos[x].salto3.Equals(cambio) ||
                            saltos[x].salto4.Equals(cambio))
                        {
                            valido = true;
                            break;
                        }
                        else
                        {
                            valido = false;
                            break;
                        }
                    }
                }
            }
            return valido;
        }
        
        /// <summary>
        /// Insertar datos a la base de datos, ya sea si el juego se reinicio
        /// o si el juego  se resolvio.
        /// </summary>
        /// <param name="objFelLi"></param>
        public void insertarDatos(ObjFelLi objFelLi)
        {
            new Datos.DBFel_Li().Insertar(objFelLi);
        }
    }
}
