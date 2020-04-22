using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaClase4
{
    public static class Extensiones
    {
        // Punto 1
        public static int ContarPalabras(this string texto)
        {
            return texto.Split(' ').Length;
        }

        // Punto 2
        public static int ContarPalabras(this string texto,char a)
        {
            return texto.Split(a).Length;
        }

        // Punto 3
        public static decimal DiferenciaTiempo(this DateTime fecha1, DateTime fecha2)
        {
            var Diferencia = fecha1 - fecha2;
            var Segundos = Diferencia.TotalSeconds;
            int SegundosEnteros = Convert.ToInt32(Segundos);
            decimal DiferenciaMinutos = SegundosEnteros / 60;
            return DiferenciaMinutos;
        }

        // Punto 4
        public static decimal ObtenerPromedio(this List<int>Enteros)
        {
            decimal prom = 0;
            int c = 0;
            foreach (int x in Enteros)
            {
                prom = prom + x;
                c++;
            }
            prom = prom / c;
            return prom;
        }

        // Punto 5
        public static int DiferenciaParImpar(this List<int> Enteros)
        {
            int suma = 0;
            int resta = 0;

            foreach (int x in Enteros)
            {
                if ( x%2==0)
                {
                    suma = suma + x;
                }
                else
                {
                    resta = resta - x;
                }
            }
            int Diferencia = suma * resta;
            return Diferencia;
        }

        // Punto 6


        // Punto 7
        public static string RetornarStringInvertido(this string texto)
        {
            string invertido = "";
            for (int i = texto.Length-1; i >= 0; i--)
            {
                invertido += texto[i];
            }
            return invertido;          
        }
    }

}
