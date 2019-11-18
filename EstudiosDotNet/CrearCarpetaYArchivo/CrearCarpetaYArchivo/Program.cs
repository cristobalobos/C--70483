using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CrearCarpetaYArchivo
{
    class Program
    {
        static void Main(string[] args)
        {
            string carpetaRaiz = @"C:\"; //indicamos la carpeta de arranque para nuestras pruebas
            string ruta = Path.Combine(carpetaRaiz, "CarpetaCreada"); //Creamos una carpeta dentro de la raiz indicada
            Directory.CreateDirectory(ruta);
            string archivo = Path.GetRandomFileName(); //creamos el nuevo archivo alateoreo
            ruta = Path.Combine(ruta, archivo); //combinemos el nombre de archivos con la ruta a nuestra carpeta

            //Creamos el arcivo y escribimos en él

            if (!File.Exists(ruta))
            {
                using (FileStream fs = File.Create(ruta))
                { //Se genera el archivo aunque ya exista
                    for (byte i = 0; i < 20; i++)
                        fs.WriteByte(i);

                }
            }

            //leemos el archivo para comrpobar que se haya escrito correctamente

            Console.WriteLine("Contenido leido del archivo {0}", ruta);

            try
            {
                byte[] bufferLectura = File.ReadAllBytes(ruta);
                foreach (byte b in bufferLectura)
                    Console.WriteLine(b);


            }
            catch (IOException e) { Console.WriteLine(e.Message); }
            Console.WriteLine("Fin de los datos");
            System.Console.ReadKey();




        }
    }
}
