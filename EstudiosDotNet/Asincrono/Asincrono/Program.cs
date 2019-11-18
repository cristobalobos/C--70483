using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Asincrono
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.CrearArchivoAsincrono("pruebas.txt").Wait();
            Console.ReadLine();
        }

        public static async Task CrearArchivoAsincrono(string nombreArchivo)
        {
            using (StreamWriter writer = File.CreateText(nombreArchivo))

                for (int i = 0; i < 100; i++)
                {
                    await writer.WriteAsync("Esto es una prueba\r\n");
                }
        }
    }
}

