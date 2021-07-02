using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        public void retornar_Fecha_Hora()
        {
            this.txtFechaHora.Text = DateTime.Now.ToString();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            this.retornar_Fecha_Hora();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal menu = new MenuPrincipal();
            menu.Show();

        }
    }
}
