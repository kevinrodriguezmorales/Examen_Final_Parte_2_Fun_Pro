
using System;
using System.Collections.Generic;
using System.IO;

namespace Examen_Final_Parte_2_Fun_Pro.Models
{
    public class GestorVideojuegos
    {
        private string p_rutaArchivo = "base_de_informacion.txt";
        private List<Videojuego> p_listaJuegos;

        public GestorVideojuegos()
        {
            p_listaJuegos = new List<Videojuego>();
            p_CargarJuegos();
        }

        public void p_RegistrarJuego(Videojuego juego)
        {
            p_listaJuegos.Add(juego);
            p_GuardarJuegos();
        }

        private void p_CargarJuegos()
        {
            if (File.Exists(p_rutaArchivo))
            {
                using (StreamReader sr = new StreamReader(p_rutaArchivo))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            var data = line.Split(',');
                            if (data.Length >= 2)
                            {
                                p_listaJuegos.Add(new Videojuego(data[0], data[1]));
                            }
                        }
                    }
                }
            }
        }

        private void p_GuardarJuegos()
        {
            using (StreamWriter sw = new StreamWriter(p_rutaArchivo))
            {
                foreach (var juego in p_listaJuegos)
                {
                    sw.WriteLine($"{juego.p_nombreJuego},{juego.p_resultado},{juego.p_puntosObtenidos}");
                }
            }
        }

        public int p_CalcularPuntosTotales()
        {
            int totalPuntos = 0;
            foreach (var juego in p_listaJuegos)
            {
                totalPuntos += juego.p_puntosObtenidos;
            }
            return totalPuntos;
        }

        public List<Videojuego> p_ObtenerJuegos()
        {
            return p_listaJuegos;
        }
    }

}
