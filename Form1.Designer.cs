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
            this.labelPuntosTotales = new System.Windows.Forms.Label();

            // Inicializar las columnas del DataGridView
            this.NombreJuego = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntos = new System.Windows.Forms.DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();

            // textBoxNombreJuego
            this.textBoxNombreJuego.Location = new System.Drawing.Point(13, 13);
            this.textBoxNombreJuego.Name = "textBoxNombreJuego";
            this.textBoxNombreJuego.Size = new System.Drawing.Size(200, 22);
            this.textBoxNombreJuego.TabIndex = 0;

            // comboBoxResultado
            this.comboBoxResultado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxResultado.FormattingEnabled = true;
            this.comboBoxResultado.Items.AddRange(new object[] {
            "Gané",
            "Perdí"});
            this.comboBoxResultado.Location = new System.Drawing.Point(230, 13);
            this.comboBoxResultado.Name = "comboBoxResultado";
            this.comboBoxResultado.Size = new System.Drawing.Size(121, 24);
            this.comboBoxResultado.TabIndex = 1;

            // buttonAgregar
            this.buttonAgregar.Location = new System.Drawing.Point(370, 13);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(100, 24);
            this.buttonAgregar.TabIndex = 2;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);

            // dataGridView
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreJuego,
            this.Resultado,
            this.Puntos});
            this.dataGridView.Location = new System.Drawing.Point(13, 50);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(457, 250);
            this.dataGridView.TabIndex = 3;

            // NombreJuego
            this.NombreJuego.HeaderText = "Nombre del Juego";
            this.NombreJuego.MinimumWidth = 6;
            this.NombreJuego.Name = "NombreJuego";
            this.NombreJuego.Width = 150;

            // Resultado
            this.Resultado.HeaderText = "Resultado";
            this.Resultado.MinimumWidth = 6;
            this.Resultado.Name = "Resultado";
            this.Resultado.Width = 125;

            // Puntos
            this.Puntos.HeaderText = "Puntos Obtenidos";
            this.Puntos.MinimumWidth = 6;
            this.Puntos.Name = "Puntos";
            this.Puntos.Width = 125;

            // labelPuntosTotales
            this.labelPuntosTotales.AutoSize = true;
            this.labelPuntosTotales.Location = new System.Drawing.Point(370, 310);
            this.labelPuntosTotales.Name = "labelPuntosTotales";
            this.labelPuntosTotales.Size = new System.Drawing.Size(100, 17);
            this.labelPuntosTotales.TabIndex = 4;
            this.labelPuntosTotales.Text = "Puntos Totales: 0";

            // Form1
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.labelPuntosTotales);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.comboBoxResultado);
            this.Controls.Add(this.textBoxNombreJuego);
            this.Name = "Form1";
            this.Text = "Registro de Videojuegos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

