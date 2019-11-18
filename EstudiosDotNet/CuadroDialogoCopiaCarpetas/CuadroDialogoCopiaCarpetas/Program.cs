using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace CuadroDialogoCopiaCarpetas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indica el nombre de la carpeta a copiar");

            string carpetaOrigen = Console.ReadLine();

            if (Directory.Exists(carpetaOrigen)){
                string carpetaDestino = Path.Combine(carpetaOrigen + "_copia");
                Console.WriteLine($"Copiado de {carpetaOrigen} a {carpetaDestino}");

                FileSystem.CopyDirectory(carpetaOrigen, carpetaDestino, UIOption.AllDialogs);
            } else

                Console.WriteLine($"El nombre introducido {carpetaOrigen} no existe como carpeta");

            Console.ReadLine();

        }
    }
}
