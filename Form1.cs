using Examen_Final_Parte_2_Fun_Pro.Models;
using System;
using System.IO;
using System.Windows.Forms;

namespace RegistroVideojuegos
{
    public partial class Form1 : Form
    {
        private GestorVideojuegos gestor;
        private int puntosTotales = 0;

        public Form1()
        {
            InitializeComponent();
            gestor = new GestorVideojuegos();

            ActualizarTabla();
            ActualizarPuntosTotales();

            VerificarContenidoArchivo();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            string nombreJuego = textBoxNombreJuego.Text;
            string resultado = comboBoxResultado.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(nombreJuego))
            {
                MessageBox.Show("Por favor, ingresa el nombre del juego.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(resultado))
            {
                MessageBox.Show("Por favor, selecciona un resultado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var juego = new Videojuego(nombreJuego, resultado);
            gestor.RegistrarJuego(juego);

            ActualizarTabla();
            ActualizarPuntosTotales();

            VerificarContenidoArchivo();

            LimpiarCampos();
        }

        private void ActualizarTabla()
        {
            dataGridView.Rows.Clear();

            foreach (var juego in gestor.ObtenerJuegos())
            {
                dataGridView.Rows.Add(juego.p_nombreJuego, juego.p_resultado, juego.p_puntosObtenidos);
            }
        }

        private void ActualizarPuntosTotales()
        {
            puntosTotales = gestor.CalcularPuntosTotales();
            labelPuntosTotales.Text = "Puntos Totales: " + puntosTotales;
        }

        private void LimpiarCampos()
        {
            textBoxNombreJuego.Text = string.Empty;
            comboBoxResultado.SelectedIndex = -1;
        }

        private void LimpiarArchivo()
        {
            gestor.LimpiarJuegos();

            ActualizarTabla();
            ActualizarPuntosTotales();

            VerificarContenidoArchivo();
        }

        private void VerificarContenidoArchivo()
        {
            if (File.Exists(GestorVideojuegos.p_rutaArchivo) && new FileInfo(GestorVideojuegos.p_rutaArchivo).Length > 0)
            {
                buttonLimpiar.Visible = true;
            }
            else
            {
                buttonLimpiar.Visible = false;
            }
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarArchivo();
        }

    }
}