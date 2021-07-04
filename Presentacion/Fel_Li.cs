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
            menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal menu = new MenuPrincipal();
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
            this.validaciones(ficha_seleccionada, espacio_mover);
        }


        /// <summary>
        /// VALIDACION QUE NO RETROCEDA
        /// </summary>
        /// <param name="seleccionado"></param>
        /// <param name="cambio"></param>
        /// <param name="nombre_ficha"></param>
        /// <returns></returns>
        public bool validar_NO_retroceder(PictureBox seleccionado, PictureBox cambio, string nombre_ficha)
        {
            //NOMBRE DE LOS BOTONES
            string nombre1 = seleccionado.Name;
            string nombre2 = cambio.Name;

            //NOMBRE DE LA IMAGEN
            string nombre_seleccionado = Path.GetFileName(seleccionado.Tag.ToString());

            //VARIABLE A RETORNAR
            bool validacion = true;

            char separador = '_';

            string[] valores1 = nombre1.Split(separador);
            string[] valores2 = nombre2.Split(separador);

            string letra1 = valores1[0];
            int num1 = Convert.ToInt32(valores1[1]);

            string letra2 = valores2[0];
            int num2 = Convert.ToInt32(valores2[1]);

            if (letra1.Equals(letra2))
            {
                if (num1 < num2)
                {
                    validacion = false;
                }
            }
            else if (letra1 != letra2)
            {
                if (ultimo_cambio.Equals(nombre2) && nombre_seleccionado == nombre_ficha)
                {
                    validacion = false;
                }
            }
            else
            {
                validacion = true;
            }

            return validacion;


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
                if (this.validar_NO_retroceder(seleccionado, cambio, nombre_ficha))
                {
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
                        txtAdyacente.Text = Convert.ToString(movimientos_adyacentes);
                    }

                    else
                    {
                        if (juego.validarMovimientoSalto(selec, camb))
                        {
                            saltos = saltos + 1;
                            txtSaltos.Text = Convert.ToString(saltos);
                        }
                    }



                }
            }
            else
            {
                MessageBox.Show("ERROR EN LAS FICHAS SELECCIONADAS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ficha_seleccionada = null;
                espacio_mover = null;

                txtAdyacente.Text = Convert.ToString(movimientos_adyacentes);
                txtSaltos.Text = Convert.ToString(saltos);

            }

        }

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
        }
    }
}
