
using System;
using System.Collections.Generic;
using System.IO;

namespace Examen_Final_Parte_2_Fun_Pro.Models
{
    public class GestorVideojuegos
    {
        public static string p_rutaArchivo = "base_de_informacion.txt";
        private List<Videojuego> p_listaJuegos;

        public GestorVideojuegos()
        {
            p_listaJuegos = new List<Videojuego>();
            CargarJuegos();
        }

        public void RegistrarJuego(Videojuego juego)
        {
            p_listaJuegos.Add(juego);
            GuardarJuegos();
        }

        private void CargarJuegos()
        {
            if (File.Exists(p_rutaArchivo))
            {
                using (FileStream fs = new FileStream(p_rutaArchivo, FileMode.Open, FileAccess.Read))
                using (BinaryReader br = new BinaryReader(fs))
                {
                    while (fs.Position < fs.Length)
                    {
                        string nombreJuego = br.ReadString();
                        string resultado = br.ReadString();
                        p_listaJuegos.Add(new Videojuego(nombreJuego, resultado));
                    }
                }
            }
        }

        private void GuardarJuegos()
        {
            using (StreamWriter sw = new StreamWriter(p_rutaArchivo))
            {
                foreach (var juego in p_listaJuegos)
                {
                    sw.WriteLine($"{juego.p_nombreJuego},{juego.p_resultado},{juego.p_puntosObtenidos}");
                }
            }
        }

        public int CalcularPuntosTotales()
        {
            int totalPuntos = 0;
            foreach (var juego in p_listaJuegos)
            {
                totalPuntos += juego.p_puntosObtenidos;
            }
            return totalPuntos;
        }

        public List<Videojuego> ObtenerJuegos()
        {
            return p_listaJuegos;
        }

        public void LimpiarJuegos()
        {
            p_listaJuegos.Clear();
            File.WriteAllText(p_rutaArchivo, string.Empty);
        }
    }

}
