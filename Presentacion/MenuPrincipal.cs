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
using System.Windows.Forms.DataVisualization.Charting;

namespace Presentacion
{
    public partial class MenuPrincipal : Form
    {
        Negocio.nMenuPrincipal logica;
        string nombre_jugador;


        public MenuPrincipal()
        {
            InitializeComponent();
            logica = new nMenuPrincipal();
        }

        /// <summary>
        /// Obtener el nombre que se ingresó
        /// </summary>
        /// <param name="nombre"></param>
        public void nombre(string nombre)
        {
            this.txtJugador.Text = nombre;
        }
       
        /// <summary>
       /// Hacer el grafico de pastel
       /// </summary>
        public void graficoPastel()
        {
            String[] serie = { "Resuelto", "Reinicio" };
            int[] cant = logica.listPastel().ToArray();

            Pastel.Titles.Add("Resuelto - Reinicio");
            Pastel.Palette = ChartColorPalette.Pastel;

            for (int x = 0; x < serie.Length;  x++)
            {
                // Series seriegf = chart1.Series.Add(serie[x]);
                //seriegf.Label = cant[x].ToString();
                //seriegf.Points.Add(cant[x]);

                Pastel.Series["Series1"].Points.AddXY(serie[x], cant[x]);
            }
        }

        /// <summary>
        /// Chart de top 3
        /// </summary>
        public void top3()
        {
            String[] serie = logica.usuarios().ToArray();
            int[] cant = logica.resultados_usuarios().ToArray();

            Mejores3.Titles.Add("Resuelto más veces");
            Mejores3.Palette = ChartColorPalette.Pastel;

            for (int x = 0; x < serie.Length; x++)
            {
               

                Series seriegf = Mejores3.Series.Add(serie[x]);
                seriegf.Label = cant[x].ToString();
                seriegf.Points.Add(cant[x]);
            }
        }

        /// <summary>
        /// Juego resuelto con menos movimientos adyacentes
        /// </summary>
        public void juegoResueltoMenos()
        {
            String[] serie = logica.consultar_id().ToArray();
            int[] cant = logica.movimiento_adyacente().ToArray();

            jugadas.Titles.Add("Resuelto menos movimientos");
            jugadas.Palette = ChartColorPalette.Pastel;

            for (int x = 0; x < serie.Length; x++)
            {


                Series seriegf = jugadas.Series.Add(serie[x]);
                seriegf.Label = cant[x].ToString();
                seriegf.Points.Add(cant[x]);
            }
        }
        
        /// <summary>
        /// Se dirige al formulario como jugar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnComoJugar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ComoJugar informacion = new ComoJugar();
            informacion.Show();

        }

        /// <summary>
        /// Se dirige al formulario como jugar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbComoJugar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ComoJugar informacion = new ComoJugar();
            informacion.Show();
        }

        /// <summary>
        /// Se dirige al formulario del juego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnJugar_Click(object sender, EventArgs e)
        {
            if (this.validarNombre())
            {
                this.Hide();
                Fel_Li juego = new Fel_Li();
                juego.nombre(nombre_jugador);
                juego.fecha(DateTime.Now);
                juego.Show();
            }
        }

        /// <summary>
        ///  Se dirige al formulario del juego
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbJugar_Click(object sender, EventArgs e)
        {
           

            if (this.validarNombre())
            {
                this.Hide();
                Fel_Li juego = new Fel_Li();
                juego.nombre(nombre_jugador);
                juego.fecha(DateTime.Now);
                juego.Show();
            }

            
        }

        /// <summary>
        /// Se dirige al formulario de reportes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReportes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reportes reportes = new Reportes();
            reportes.Show();

        }

        /// <summary>
        /// Se dirige al formulario de reportes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbReportes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reportes reportes = new Reportes();
            reportes.Show();
        }


        /// <summary>
        /// Se sale de la app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Se sale de la app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Validacion si el nombre existe en la base de datosS
        /// </summary>
        /// <returns></returns>
        public bool validarNombre()
        {
            nombre_jugador = txtJugador.Text;

           
            if (nombre_jugador.Equals(""))
            {
                MessageBox.Show("Error debes ingresar un nombre ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                bool validar = logica.validarExistenciaUsuario(nombre_jugador);

                MessageBox.Show("Esperamos que disfrutes el juego " + nombre_jugador, "BIENVENIDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }

        }

        /// <summary>
        /// Cuando cargue el formulario que cargue los graficos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.graficoPastel();
            this.top3();
            this.juegoResueltoMenos();
            
        }
    }
}
