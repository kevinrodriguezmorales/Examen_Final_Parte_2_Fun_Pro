namespace RegistroVideojuegos
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxNombreJuego;
        private System.Windows.Forms.ComboBox comboBoxResultado;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label labelPuntosTotales;

        // Columnas del DataGridView
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreJuego;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntos;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxNombreJuego = new System.Windows.Forms.TextBox();
            this.comboBoxResultado = new System.Windows.Forms.ComboBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.NombreJuego = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelPuntosTotales = new System.Windows.Forms.Label();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNombreJuego
            // 
            this.textBoxNombreJuego.Location = new System.Drawing.Point(12, 296);
            this.textBoxNombreJuego.Name = "textBoxNombreJuego";
            this.textBoxNombreJuego.Size = new System.Drawing.Size(200, 20);
            this.textBoxNombreJuego.TabIndex = 0;
            // 
            // comboBoxResultado
            // 
            this.comboBoxResultado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxResultado.FormattingEnabled = true;
            this.comboBoxResultado.Items.AddRange(new object[] {
            "Gané",
            "Perdí"});
            this.comboBoxResultado.Location = new System.Drawing.Point(12, 351);
            this.comboBoxResultado.Name = "comboBoxResultado";
            this.comboBoxResultado.Size = new System.Drawing.Size(200, 21);
            this.comboBoxResultado.TabIndex = 1;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackColor = System.Drawing.Color.Teal;
            this.buttonAgregar.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregar.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAgregar.Location = new System.Drawing.Point(12, 388);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(200, 36);
            this.buttonAgregar.TabIndex = 2;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreJuego,
            this.Resultado,
            this.Puntos});
            this.dataGridView.Location = new System.Drawing.Point(230, 278);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(480, 250);
            this.dataGridView.TabIndex = 3;
            // 
            // NombreJuego
            // 
            this.NombreJuego.HeaderText = "Nombre del Juego";
            this.NombreJuego.MinimumWidth = 6;
            this.NombreJuego.Name = "NombreJuego";
            this.NombreJuego.Width = 150;
            // 
            // Resultado
            // 
            this.Resultado.HeaderText = "Resultado";
            this.Resultado.MinimumWidth = 6;
            this.Resultado.Name = "Resultado";
            this.Resultado.Width = 125;
            // 
            // Puntos
            // 
            this.Puntos.HeaderText = "Puntos Obtenidos";
            this.Puntos.MinimumWidth = 6;
            this.Puntos.Name = "Puntos";
            this.Puntos.Width = 125;
            // 
            // labelPuntosTotales
            // 
            this.labelPuntosTotales.AutoSize = true;
            this.labelPuntosTotales.BackColor = System.Drawing.Color.Transparent;
            this.labelPuntosTotales.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuntosTotales.Location = new System.Drawing.Point(564, 540);
            this.labelPuntosTotales.Name = "labelPuntosTotales";
            this.labelPuntosTotales.Size = new System.Drawing.Size(123, 15);
            this.labelPuntosTotales.TabIndex = 4;
            this.labelPuntosTotales.Text = "Puntos Totales: 0";
            this.labelPuntosTotales.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.Location = new System.Drawing.Point(12, 430);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(200, 36);
            this.buttonLimpiar.TabIndex = 5;
            this.buttonLimpiar.Text = "Limpiar Data";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Examen_Final_Parte_2_Fun_Pro.Properties.Resources.banner1;
            this.pictureBox2.Location = new System.Drawing.Point(12, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(698, 243);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre de juego";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Seleccionar resultado";
            // 
            // Form1
            // 
            this.BackgroundImage = global::Examen_Final_Parte_2_Fun_Pro.Properties.Resources.back_3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(722, 575);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.labelPuntosTotales);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.comboBoxResultado);
            this.Controls.Add(this.textBoxNombreJuego);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Registro de Videojuegos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

