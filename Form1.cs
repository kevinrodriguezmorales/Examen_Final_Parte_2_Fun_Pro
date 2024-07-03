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

            p_ActualizarTabla();
            p_ActualizarPuntosTotales();
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
            gestor.p_RegistrarJuego(juego);

            p_ActualizarTabla();
            p_ActualizarPuntosTotales();

            p_LimpiarCampos();
        }

        private void p_ActualizarTabla()
        {
            dataGridView.Rows.Clear();

            // Agregar registro al DataGridView
            foreach (var juego in gestor.p_ObtenerJuegos())
            {
                dataGridView.Rows.Add(juego.p_nombreJuego, juego.p_resultado, juego.p_puntosObtenidos);
            }
        }

        private void p_ActualizarPuntosTotales()
        {
            // Actualizar puntos totales
            puntosTotales = gestor.p_CalcularPuntosTotales();
            labelPuntosTotales.Text = "Puntos Totales: " + puntosTotales;
        }

        private void GuardarDatos()
        {
            using (StreamWriter writer = new StreamWriter("base_de_informacion.txt"))
            {
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string juego = row.Cells["NombreJuego"].Value.ToString();
                        string resultado = row.Cells["Resultado"].Value.ToString();
                        string puntos = row.Cells["Puntos"].Value.ToString();
                        writer.WriteLine($"{juego},{resultado},{puntos}");
                    }
                }
                writer.WriteLine($"TotalPuntos,{puntosTotales}");
            }
        }

        private void CargarDatos()
        {
            if (File.Exists("base_de_informacion.txt"))
            {
                using (StreamReader reader = new StreamReader("base_de_informacion.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        if (data[0] == "TotalPuntos")
                        {
                            puntosTotales = int.Parse(data[1]);
                            labelPuntosTotales.Text = "Puntos Totales: " + puntosTotales;
                        }
                        else
                        {
                            dataGridView.Rows.Add(data[0], data[1], int.Parse(data[2]));
                        }
                    }
                }
            }
        }

        private void p_LimpiarCampos()
        {
            textBoxNombreJuego.Text = string.Empty;
            comboBoxResultado.SelectedIndex = -1;
        }
    }
}