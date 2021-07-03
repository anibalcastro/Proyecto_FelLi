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

        string ultimo_cambio = "";
        string nombre_ficha = "";


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
            A_7.Image = Image.FromFile((@"C:\Users\admin\source\repos\Proyecto_FelLi\Presentacion\Resources\ficha-de-poker.png");
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
    }
}
