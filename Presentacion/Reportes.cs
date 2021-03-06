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
    public partial class Reportes : Form
    {
        List<ObjRep1> reporte1 = new List<ObjRep1>();
        List<ObjRep2_3> reporte2 = new List<ObjRep2_3>();
        List<ObjRep2_3> reporte3 = new List<ObjRep2_3>();
        List<ObjUsuarios> usuarios = new List<ObjUsuarios>();

        Negocio.nReportes nReportes;

        public Reportes()
        {
            InitializeComponent();
            nReportes = new nReportes();
            this.dt_reportes.AllowUserToAddRows = false;
        }

        /// <summary>
        /// Llenar combobox de todos los usuarios 
        /// </summary>
        public void llenar_cbUsuario()
        {
            usuarios = nReportes.cb_llenar();
            cbUsuarios.ValueMember = "nombre_jugador";
            cbUsuarios.DisplayMember = "nombre_jugador";

            cbUsuarios.DataSource = usuarios;

        }

        /// <summary>
        /// Darle formato al reporte 1
        /// </summary>
        /// <param name="nombre"></param>
        public void dt_rep1(string nombre)
        {

            this.tReporte.Text = "REPORTE 1";

            reporte1 = nReportes.reporte1(nombre);
            DataTable mov_adyac = new DataTable("mov_adyac");
            DataColumn colum1 = new DataColumn("USUARIO");
            
            DataColumn colum3 = new DataColumn("HORA");
            DataColumn colum4 = new DataColumn("CANT ADYACENTES");

            mov_adyac.Columns.Add(colum1);
           
            mov_adyac.Columns.Add(colum3);
            mov_adyac.Columns.Add(colum4);


            for (int x = 0; x < reporte1.Count; x++)
            {
                mov_adyac.Rows.Add
                    (
                    reporte1[x].nombre,
                    reporte1[x].fecha.Date,
                    reporte1[x].mov_Adyacentes
                    );
            }

            dt_reportes.DataSource = mov_adyac;
        }

        /// <summary>
        /// Darle formato al reporte 2
        /// </summary>
        public void dt_rep2()
        {
            //dt_reportes.Rows.Clear();
            //dt_reportes.Columns.Clear();
            this.tReporte.Text = "REPORTE 2";

            reporte2 = nReportes.reporte2();
            DataTable table = new DataTable("table");
            DataColumn colum1 = new DataColumn("USUARIO");
            DataColumn colum2 = new DataColumn("CANT RESUELTO");


            table.Columns.Add(colum1);
            table.Columns.Add(colum2);



            for (int x = 0; x < reporte2.Count; x++)
            {
                table.Rows.Add
                    (
                    reporte2[x].nombre,
                    reporte2[x].cant
                    );
            }

            dt_reportes.DataSource = table;
        }

        /// <summary>
        /// Darle formato al reporte 3
        /// </summary>
        /// <param name="nombre"></param>
        public void dt_rep3(string nombre)
        {
            //dt_reportes.Rows.Clear();
            //dt_reportes.Columns.Clear();
            this.tReporte.Text = "REPORTE 3";

            reporte3 = nReportes.reporte3(nombre);
            DataTable table = new DataTable("table");
            DataColumn colum1 = new DataColumn("USUARIO");
            DataColumn colum2 = new DataColumn("CANT REINICIO");


            table.Columns.Add(colum1);
            table.Columns.Add(colum2);



            for (int x = 0; x < reporte3.Count; x++)
            {
                table.Rows.Add
                    (
                    reporte3[x].nombre,
                    reporte3[x].cant
                    );
            }

            dt_reportes.DataSource = table;
        }

        /// <summary>
        /// Al cargar que se active el reporte 2 
        /// cargue el combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reportes_Load(object sender, EventArgs e)
        {
            this.rbRep2.Checked = true;
            this.rbRep1.Checked = false;
            this.rbRep3.Checked = false;
            this.llenar_cbUsuario();
            this.dt_rep2();
        }

        /// <summary>
        /// Validar que cuando el radiobutton rep1 este activo que habilite 
        /// el groupbox y ejecute el dt_rep1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbRep1_CheckedChanged(object sender, EventArgs e)
        {
            this.groupBox1.Enabled = true;
            string usuario = this.cbUsuarios.SelectedValue.ToString();
            this.dt_rep1(usuario);
        }

        /// <summary>
        /// Deshabilitar el groupbox
        /// porque no se necesita
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbRep2_CheckedChanged(object sender, EventArgs e)
        {
            this.groupBox1.Enabled = false;
            this.dt_rep2();
        }


        private void rbRep3_CheckedChanged(object sender, EventArgs e)
        {
            this.groupBox1.Enabled = true;
            string usuario = this.cbUsuarios.SelectedValue.ToString();
            this.dt_rep3(usuario);
        }

        /// <summary>
        /// Al ser selccionado alguno, ejecute la accion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            string usuario = this.cbUsuarios.SelectedValue.ToString();
            this.validarSeleccion(usuario);
        }

        /// <summary>
        /// Validar cual radiobuttom fue seleccionado
        /// </summary>
        /// <param name="nombre"></param>
        public void validarSeleccion(string nombre)
        {
            if (this.rbRep1.Checked == true && this.rbRep2.Checked == false && this.rbRep3.Checked == false)
            {
                this.dt_rep1(nombre);
            }
            else if (this.rbRep1.Checked == false && this.rbRep2.Checked == false && this.rbRep3.Checked == true)
            {
                this.dt_rep3(nombre);
            }

        }

        /// <summary>
        /// Regresar  al menu principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal principal = new MenuPrincipal();
            principal.Show();
        }

        /// <summary>
        /// Regresar al menu principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal principal = new MenuPrincipal();
            principal.Show();
        }
    }
}
