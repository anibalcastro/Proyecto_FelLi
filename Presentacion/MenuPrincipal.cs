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
    public partial class MenuPrincipal : Form
    {
        Negocio.nMenuPrincipal logica;

        public MenuPrincipal()
        {
            InitializeComponent();
            logica = new nMenuPrincipal();
        }

        private void txtJugador_Validating(object sender, CancelEventArgs e)
        {
            string usuario = txtJugador.Text;

            bool validar = logica.validarExistenciaUsuario(usuario);

            if (validar)
            {
                MessageBox.Show("Esperamos que disfrutes el juego " + usuario, "BIENVENIDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            this.Hide();
            Fel_Li juego = new Fel_Li();
            juego.Show();
        }

        private void pbJugar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fel_Li juego = new Fel_Li();
            juego.Show();
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
    }
}
