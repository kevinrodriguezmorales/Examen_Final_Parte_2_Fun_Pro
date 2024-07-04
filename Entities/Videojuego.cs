using System;

namespace Examen_Final_Parte_2_Fun_Pro.Models
{
    public class Videojuego
    {
        public string p_nombreJuego { get; set; }
        public string p_resultado { get; set; }
        public int p_puntosObtenidos { get; set; }

        private const int p_puntosGanados = 100;
        private const int p_puntosPerdidos = -20;

        public Videojuego(string nombreJuego, string resultado)
        {
            p_nombreJuego = nombreJuego;
            p_resultado = resultado;
            p_puntosObtenidos = CalcularPuntos();
        }

        private int CalcularPuntos()
        {
            return p_resultado.ToLower() == "gané" ? p_puntosGanados : p_puntosPerdidos;
        }
    }
}