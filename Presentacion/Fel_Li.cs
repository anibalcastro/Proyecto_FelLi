using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Objetos;
using Negocio;
using System.IO;

namespace Presentacion
{
    public partial class Fel_Li : Form
    {
        Negocio.nFel_Li juego;

        Panel nombre_panel;

        PictureBox ficha_seleccionada;
        PictureBox espacio_mover;

        int movimientos_adyacentes = 0;
        int saltos = 0;

        string nombre_jugador;
        DateTime fecha_hora;

        string ultimo_cambio = "";
        string nombre_ficha = "";

        Objetos.ObjFelLi FelLi;


        public Fel_Li()
        {
            InitializeComponent();
            juego = new nFel_Li();
        }

        /// <summary>
        /// Obtener el nombre dl jugador
        /// </summary>
        /// <param name="nombre"></param>
        public void nombre(string nombre)
        {
            nombre_jugador = nombre;
        }

        public void fecha(DateTime fecha)
        {
            fecha_hora = fecha;
        }

        
        /// <summary>
        /// Agregar las imagenes a los picture box
        /// </summary>
        public void imagenes_botones()
        {

            A_1.Image = Image.FromFile(@"C:\Users\admin\source\repos\Proyecto_FelLi\Presentacion\Resources\ficha-de-poker.png");
            A_1.Tag = (@"C:\Users\admin\source\repos\Proyecto_FelLi\Presentacion\Resources\ficha-de-poker.png");
            A_2.Image = Image.FromFile(@"C:\Users\admin\source\repos\Proyecto_FelLi\Presentacion\Resources\ficha-de-poker.png");
            A_2.Tag = (@"C:\Users\admin\source\repos\Proyecto_FelLi\Presentacion\Resources\ficha-de-poker.png");
            A_3.Image = Image.FromFile(@"C:\Users\admin\source\repos\Proyecto_FelLi\Presentacion\Resources\ficha-de-poker.png");
            A_3.Tag = (@"C:\Users\admin\source\repos\Proyecto_FelLi\Presentacion\Resources\ficha-de-poker.png");
            A_4.Image = Image.FromFile(@"C:\Users\admin\source\repos\Proyecto_FelLi\Presentacion\Resources\ficha-de-poker.png");
            A_4.Tag = (@"C:\Users\admin\source\repos\Proyecto_FelLi\Presentacion\Resources\ficha-de-poker.png");
            A_5.Image = Image.FromFile(@"C:\Users\admin\source\repos\Proyecto_FelLi\Presentacion\Resources\ficha-de-poker.png");
            A_5.Tag = (@"C:\Users\admin\source\repos\Proyecto_FelLi\Presentacion\Resources\ficha-de-poker.png");
            A_6.Image = Image.FromFile(@"C:\Users\admin\source\repos\Proyecto_FelLi\Presentacion\Resources\ficha-de-poker.png");
            A_6.Tag = (@"C:\Users\admin\source\repos\Proyecto_FelLi\Presentacion\Resources\ficha-de-poker.png");
            A_7.Image = Image.FromFile(@"C:\Users\admin\source\repos\Proyecto_FelLi\Presentacion\Resources\ficha-de-poker.png");
            A_7.Tag = (@"C:\Users\admin\source\repos\Proyecto_FelLi\Presentacion\Resources\ficha-de-poker.png");
            A_8.Image = Image.FromFile(@"C:\Users\admin\source\repos\Proyecto_FelLi\Presentacion\Resources\ficha-de-poker.png");
            A_8.Tag = (@"C:\Users\admin\source\repos\Proyecto_FelLi\Presentacion\Resources\ficha-de-poker.png");


            m_0.Image = Image.FromFile(@"C:\Users\admin\source\repos\Proyecto_FelLi\Presentacion\Resources\vacio.png");
            m_0.Tag = (@"C:\Users\admin\source\repos\Proyecto_FelLi\Presentacion\Resources\vacio.png");


            B_1.Image = Image.FromFile(@"C:\Users\admin\source\repos\Proyecto_FelLi\Presentacion\Resources\juego.png");
            B_1.Tag = (@"C:\Users\admin\source\repos\Proyecto_FelLi\Presentacion\Resources\juego.png");
            B_2.Image = Image.FromFile(@"C:\Users\admin\source\repos\Proyecto_FelLi\Presentacion\Resources\juego.png");
            B_2.Tag = (@"C:\Users\admin\source\repos\Proyecto_FelLi\Presentacion\Resources\juego.png");
            B_3.Image = Image.FromFile(@"C:\Users\admin\source\repos\Proyecto_FelLi\Presentacion\Resources\juego.png");
            B_3.Tag = (@"C:\Users\admin\source\repos\Proyecto_FelLi\Presentacion\Resources\juego.png");
            B_4.Image = Image.FromFile(@"C:\Users\admin\source\repos\Proyecto_FelLi\Presentacion\Resources\juego.png");
            B_4.Tag = (@"C:\Users\admin\source\repos\Proyecto_FelLi\Presentacion\Resources\juego.png");
            B_5.Image = Image.FromFile(@"C:\Users\admin\source\repos\Proyecto_FelLi\Presentacion\Resources\juego.png");
            B_5.Tag = (@"C:\Users\admin\source\repos\Proyecto_FelLi\Presentacion\Resources\juego.png");
            B_6.Image = Image.FromFile(@"C:\Users\admin\source\repos\Proyecto_FelLi\Presentacion\Resources\juego.png");
            B_6.Tag = (@"C:\Users\admin\source\repos\Proyecto_FelLi\Presentacion\Resources\juego.png");
            B_7.Image = Image.FromFile(@"C:\Users\admin\source\repos\Proyecto_FelLi\Presentacion\Resources\juego.png");
            B_7.Tag = (@"C:\Users\admin\source\repos\Proyecto_FelLi\Presentacion\Resources\juego.png");
            B_8.Image = Image.FromFile(@"C:\Users\admin\source\repos\Proyecto_FelLi\Presentacion\Resources\juego.png");
            B_8.Tag = (@"C:\Users\admin\source\repos\Proyecto_FelLi\Presentacion\Resources\juego.png");
        }
        


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal menu = new MenuPrincipal();
            menu.nombre(nombre_jugador);
            menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal menu = new MenuPrincipal();
            menu.nombre(nombre_jugador);
            menu.Show();
        }

        private void Fel_Li_Load(object sender, EventArgs e)
        {
           this.imagenes_botones();

        }

        private void ObtenerPB(object sender, MouseEventArgs e)
        {
            if (ficha_seleccionada == null)
            {
                this.obtener_PB_1(sender);
            }
            else
            {
                this.obtener_PB_2(sender);
            }
        }

        /// <summary>
        /// Asignarle el nombre del picturebox a la variable
        /// ficha_seleccionada
        /// </summary>
        /// <param name="sender"></param>
        public void obtener_PB_1(Object sender)
        {
            ficha_seleccionada = sender as PictureBox;
        }

        /// <summary>
        /// Asignarle el nombre del picturebox obtenido a la variable espacio_mover
        /// </summary>
        /// <param name="sender"></param>
        public void obtener_PB_2(Object sender)
        {
            espacio_mover = sender as PictureBox;
            this.juegoFel_Li(ficha_seleccionada, espacio_mover);
        }

      

        public bool ganador()
        {
            string ficha_roja = "juego.png";
            string ficha_azul = "ficha-de-poker.png";
            string ficha_vacio = "vacio.png";
            bool validar = false;

            // A
            string pcbA_8 = Path.GetFileName(this.A_8.Tag.ToString());
            string pcbA_7 = Path.GetFileName(this.A_7.Tag.ToString());
            string pcbA_6 = Path.GetFileName(this.A_6.Tag.ToString());
            string pcbA_5 = Path.GetFileName(this.A_5.Tag.ToString());
            string pcbA_4 = Path.GetFileName(this.A_4.Tag.ToString());
            string pcbA_3 = Path.GetFileName(this.A_3.Tag.ToString());
            string pcbA_2 = Path.GetFileName(this.A_2.Tag.ToString());
            string pcbA_1 = Path.GetFileName(this.A_1.Tag.ToString());

            // B
            string pcbB_8 = Path.GetFileName(this.B_8.Tag.ToString());
            string pcbB_7 = Path.GetFileName(this.B_7.Tag.ToString());
            string pcbB_6 = Path.GetFileName(this.B_6.Tag.ToString());
            string pcbB_5 = Path.GetFileName(this.B_5.Tag.ToString());
            string pcbB_4 = Path.GetFileName(this.B_4.Tag.ToString());
            string pcbB_3 = Path.GetFileName(this.B_3.Tag.ToString());
            string pcbB_2 = Path.GetFileName(this.B_2.Tag.ToString());
            string pcbB_1 = Path.GetFileName(this.B_1.Tag.ToString());

            //m
            string pcbm_0 = Path.GetFileName(this.m_0.Tag.ToString());



            if (pcbA_8.Equals(ficha_roja) &&
                pcbA_7.Equals(ficha_roja) &&
                pcbA_6.Equals(ficha_roja) &&
                pcbA_5.Equals(ficha_roja) &&
                pcbA_4.Equals(ficha_roja) &&
                pcbA_3.Equals(ficha_roja) &&
                pcbA_2.Equals(ficha_roja) &&
                pcbA_1.Equals(ficha_roja))
            {
                if (pcbB_8.Equals(ficha_azul) &&
                    pcbB_7.Equals(ficha_azul) &&
                    pcbB_6.Equals(ficha_azul) &&
                    pcbB_5.Equals(ficha_azul) &&
                    pcbB_4.Equals(ficha_azul) &&
                    pcbB_3.Equals(ficha_azul) &&
                    pcbB_2.Equals(ficha_azul) &&
                    pcbB_1.Equals(ficha_azul))
                {
                    if (pcbm_0.Equals(ficha_vacio))
                    {
                        FelLi = new ObjFelLi
                        {
                            nombre_jugador = nombre_jugador,
                            fecha = fecha_hora,
                            mov_adyacente = movimientos_adyacentes,
                            cant_saltos = saltos,
                            estado = "Resuelto"
                        };
                        juego.insertarDatos(FelLi);
                        MessageBox.Show("Felicidades juego resuelto", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.imagenes_botones();
                        this.movimientos_adyacentes = 0;
                        this.saltos = 0;
                        this.ultimo_cambio = "";
                        this.ficha_seleccionada = null;
                        this.espacio_mover = null;
                        this.mostarDatos();

                        validar = true;
                    }
                }
                
            }
            else
            {
                validar = false;
            }
            return validar;
        }

        public void juegoFel_Li(PictureBox seleccionado, PictureBox cambio)
        {
            string nombreImagenCambio = Path.GetFileName(cambio.Tag.ToString());
            string nombreImagenSeleccionado = Path.GetFileName(seleccionado.Tag.ToString());

            string selec = seleccionado.Name;
            string camb = cambio.Name;

            Image imagen_seleccionado = seleccionado.Image;
            Image imagen_cambio = cambio.Image;

            string nombre_vacio = ("vacio.png");

            bool ganador = this.ganador();
            bool validarAdyacente = juego.validarAdyacente(selec, camb, nombreImagenSeleccionado);
            bool validarSalto = juego.validarSalto(selec, camb, nombreImagenSeleccionado);

            if (ganador == false)
            {
                if (nombreImagenCambio.Equals(nombre_vacio))
                {
                   if (validarAdyacente)
                    {
                        nombre_ficha = Path.GetFileName(seleccionado.Tag.ToString());

                        cambio.Image = imagen_seleccionado;
                        cambio.Tag = seleccionado.Tag;

                        seleccionado.Image = imagen_cambio;
                        seleccionado.Tag = (@"C:\Users\admin\source\repos\Proyecto_FelLi\Presentacion\Resources\vacio.png");

                        ficha_seleccionada = null;
                        espacio_mover = null;

                        ultimo_cambio = seleccionado.Name;

                        movimientos_adyacentes = movimientos_adyacentes + 1;
                        this.mostarDatos();

                    }
                   else if (validarSalto)
                    {
                        nombre_ficha = Path.GetFileName(seleccionado.Tag.ToString());

                        cambio.Image = imagen_seleccionado;
                        cambio.Tag = seleccionado.Tag;

                        seleccionado.Image = imagen_cambio;
                        seleccionado.Tag = (@"C:\Users\admin\source\repos\Proyecto_FelLi\Presentacion\Resources\vacio.png");

                        ficha_seleccionada = null;
                        espacio_mover = null;

                        ultimo_cambio = seleccionado.Name;

                        saltos = saltos + 1;
                        this.mostarDatos();
                    }
                   
                }
                else
                {
                    MessageBox.Show("ERROR EN LAS FICHAS SELECCIONADAS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ficha_seleccionada = null;
                    espacio_mover = null;

                    this.mostarDatos();
                }
            }
            else
            {
                MessageBox.Show("Felicidades Ganaste", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            

        }

        /// <summary>
        /// Contiene todas las validaciones del juego
        /// </summary>
        /// <param name="seleccionado"></param>
        /// <param name="cambio"></param>
        public void validaciones(PictureBox seleccionado, PictureBox cambio)
        {
            string nombreImagenCambio = Path.GetFileName(cambio.Tag.ToString());

            

            string selec = seleccionado.Name;
            string camb = cambio.Name;

            Image imagen_seleccionado = seleccionado.Image;
            Image imagen_cambio = cambio.Image;

            string nombre_vacio = ("vacio.png");

            if (nombreImagenCambio.Equals(nombre_vacio))
            {
               // if (this.validar_NO_retroceder(seleccionado, cambio, nombre_ficha))
               // {
                    nombre_ficha = Path.GetFileName(seleccionado.Tag.ToString());

                    cambio.Image = imagen_seleccionado;
                    cambio.Tag = seleccionado.Tag;

                    seleccionado.Image = imagen_cambio;
                    seleccionado.Tag = (@"C:\Users\admin\source\repos\Proyecto_FelLi\Presentacion\Resources\vacio.png");

                    ficha_seleccionada = null;
                    espacio_mover = null;

                    ultimo_cambio = seleccionado.Name;

                    if (juego.validarMovimientoAdyacente(selec, camb))
                    {
                        movimientos_adyacentes = movimientos_adyacentes + 1;
                        this.mostarDatos();
                    }

                    else
                    {
                        if (juego.validarMovimientoSalto(selec, camb))
                        {
                            saltos = saltos + 1;
                            this.mostarDatos();
                        }
                    }



               // }
            }
            else
            {
                MessageBox.Show("ERROR EN LAS FICHAS SELECCIONADAS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ficha_seleccionada = null;
                espacio_mover = null;

                this.mostarDatos();

            }

        }

        /// <summary>
        /// Reiniciar juego 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            FelLi = new ObjFelLi
            {
                nombre_jugador = nombre_jugador,
                fecha = fecha_hora,
                mov_adyacente = movimientos_adyacentes,
                cant_saltos = saltos,
                estado = "Reinicio"
            };
            juego.insertarDatos(FelLi);
            MessageBox.Show("Juego Reinciado", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.imagenes_botones();
            this.movimientos_adyacentes = 0;
            this.saltos = 0;
            this.ultimo_cambio = "";
            this.ficha_seleccionada = null;
            this.espacio_mover = null;
            this.mostarDatos();
        }

        /// <summary>
        /// Mostrar los datos del juego
        /// movimientos adyacentes
        /// movimientos con salto
        /// nombre del jugador
        /// </summary>
        public void mostarDatos()
        {
            txtJugador.Text = this.nombre_jugador;
            this.txtAdyacente.Text = Convert.ToString(this.movimientos_adyacentes);
            this.txtSaltos.Text = Convert.ToString(this.saltos);
        }

      
    }
}
