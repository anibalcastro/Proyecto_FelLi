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
        
        private void btnComoJugar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ComoJugar informacion = new ComoJugar();
            informacion.Show();

        }

        private void pbComoJugar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ComoJugar informacion = new ComoJugar();
            informacion.Show();
        }

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

        private void btnReportes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reportes reportes = new Reportes();
            reportes.Show();

        }

        private void pbReportes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reportes reportes = new Reportes();
            reportes.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.graficoPastel();
            this.top3();
            this.juegoResueltoMenos();
            this.txtJugador.Text = nombre_jugador;
        }
    }
}
