using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerciciospract1.clases
{
    internal class Ejercicios
    {
        public void MostrarArregloNumerico()
        {
            int[] a = new int[5];
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Ingresa los numeros que quieras: ");
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int z = 0; z < a.Length; z++)
            {
                Console.WriteLine($"Ingresaste {a[z]}");
            }

        }
        public void MediaArreglo()
        {
            double[] arreglo = new double[10];
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine("Pon un número");
                arreglo[i] = double.Parse(Console.ReadLine());
            }
            double media = arreglo[0] + arreglo[1] + arreglo[2] + arreglo[3] + arreglo[4] + arreglo[5] + arreglo[6] + arreglo[7] + arreglo[8] + arreglo[9] / 10;
            Console.WriteLine(media);
        }

        public void MultiplosArreglo()
        {
            Console.WriteLine("Tamaño del arreglo");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[x];
            Console.WriteLine("Número a mostrar sus multiplos");
            int multiplos = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = multiplos * (i + 1);
                Console.WriteLine(a[i]);
            }

        }
        public void NombreConLongitud()
        {
            Console.WriteLine("Tamaño del arreglo");
            int tamaño = Convert.ToInt32(Console.ReadLine());

            string[] nombres = new string[tamaño];
            int[] longitudNombres = new int[tamaño];

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"Pon el nombre {i + 1}:");
                nombres[i] = Console.ReadLine();
                longitudNombres[i] = nombres[i].Length;
            }
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"El nombre '{nombres[i]}' tiene una longitud de: {longitudNombres[i]}");
            }
        }
    }
}
