
namespace Presentacion
{
    partial class Reportes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbRep3 = new System.Windows.Forms.RadioButton();
            this.rbRep2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rbRep1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbUsuarios = new System.Windows.Forms.ComboBox();
            this.dt_reportes = new System.Windows.Forms.DataGridView();
            this.tReporte = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_reportes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.rbRep3);
            this.panel1.Controls.Add(this.rbRep2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rbRep1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 449);
            this.panel1.TabIndex = 0;
            // 
            // rbRep3
            // 
            this.rbRep3.AutoSize = true;
            this.rbRep3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRep3.Location = new System.Drawing.Point(20, 222);
            this.rbRep3.Name = "rbRep3";
            this.rbRep3.Size = new System.Drawing.Size(231, 36);
            this.rbRep3.TabIndex = 3;
            this.rbRep3.TabStop = true;
            this.rbRep3.Text = "Cantidad de veces que un \r\núnico usuario reinició el juego. ";
            this.rbRep3.UseVisualStyleBackColor = true;
            this.rbRep3.CheckedChanged += new System.EventHandler(this.rbRep3_CheckedChanged);
            // 
            // rbRep2
            // 
            this.rbRep2.AutoSize = true;
            this.rbRep2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRep2.Location = new System.Drawing.Point(20, 165);
            this.rbRep2.Name = "rbRep2";
            this.rbRep2.Size = new System.Drawing.Size(198, 52);
            this.rbRep2.TabIndex = 2;
            this.rbRep2.TabStop = true;
            this.rbRep2.Text = "Cantidad de veces que se\r\nresolvió el juego \r\n\r\n";
            this.rbRep2.UseVisualStyleBackColor = true;
            this.rbRep2.CheckedChanged += new System.EventHandler(this.rbRep2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "TIPOS DE REPORTE";
            // 
            // rbRep1
            // 
            this.rbRep1.AutoSize = true;
            this.rbRep1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbRep1.Location = new System.Drawing.Point(20, 104);
            this.rbRep1.Name = "rbRep1";
            this.rbRep1.Size = new System.Drawing.Size(190, 36);
            this.rbRep1.TabIndex = 0;
            this.rbRep1.TabStop = true;
            this.rbRep1.Text = "Menor cantidad de\r\nMovimientos Adyacentes";
            this.rbRep1.UseVisualStyleBackColor = true;
            this.rbRep1.CheckedChanged += new System.EventHandler(this.rbRep1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbUsuarios);
            this.groupBox1.Location = new System.Drawing.Point(345, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jugadores:";
            // 
            // cbUsuarios
            // 
            this.cbUsuarios.FormattingEnabled = true;
            this.cbUsuarios.Location = new System.Drawing.Point(27, 39);
            this.cbUsuarios.Name = "cbUsuarios";
            this.cbUsuarios.Size = new System.Drawing.Size(320, 21);
            this.cbUsuarios.TabIndex = 0;
            this.cbUsuarios.SelectedIndexChanged += new System.EventHandler(this.cbUsuarios_SelectedIndexChanged);
            // 
            // dt_reportes
            // 
            this.dt_reportes.AllowUserToAddRows = false;
            this.dt_reportes.AllowUserToDeleteRows = false;
            this.dt_reportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_reportes.Location = new System.Drawing.Point(258, 167);
            this.dt_reportes.Name = "dt_reportes";
            this.dt_reportes.ReadOnly = true;
            this.dt_reportes.Size = new System.Drawing.Size(541, 284);
            this.dt_reportes.TabIndex = 2;
            // 
            // tReporte
            // 
            this.tReporte.AutoSize = true;
            this.tReporte.Location = new System.Drawing.Point(264, 151);
            this.tReporte.Name = "tReporte";
            this.tReporte.Size = new System.Drawing.Size(35, 13);
            this.tReporte.TabIndex = 3;
            this.tReporte.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 351);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(71, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tReporte);
            this.Controls.Add(this.dt_reportes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dt_reportes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbUsuarios;
        private System.Windows.Forms.DataGridView dt_reportes;
        private System.Windows.Forms.Label tReporte;
        private System.Windows.Forms.RadioButton rbRep3;
        private System.Windows.Forms.RadioButton rbRep2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbRep1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}