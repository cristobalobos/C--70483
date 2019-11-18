using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explorador
{
    class Program
    {
        static System.Collections.Specialized.StringCollection
        log = new System.Collections.Specialized.StringCollection();

        static void Main(string[] args)
        {
            //Empazamos por recuperar las unidades disponibles del equipo en el casa que haya que recorrer
            //Todo el equipo

            string[] discos = System.Environment.GetLogicalDrives();

            Console.WriteLine("Escoja un disco:  ");
            
            for (int i=0; i < discos.Length; i++) {
                Console.WriteLine($"{i+1}) {discos[i]}  ");
            }

            int valor = Convert.ToInt32(Console.ReadLine()) - 1;
            string disco = discos[valor];

         //   foreach (string disco in discos)
           // {
                System.IO.DriveInfo informacionDisco = new System.IO.DriveInfo(disco);

                //si el disco no esta cargada, lo saltamos para evitar errores de acceso

                if (!informacionDisco.IsReady)
                {
                    Console.WriteLine("\n{0} - El disco no puede ser leido, " + "se salta \n", informacionDisco.Name);
                 //   continue;
                }

                System.IO.DirectoryInfo directorioRaiz = informacionDisco.RootDirectory;

                //mostramos la unidad que estamos tratando

                Console.WriteLine("");
                Console.WriteLine("*******************************************************");
                Console.WriteLine(" U N I D A D   E N  C U R S O  ========> " + "{0}", directorioRaiz.FullName);
                Console.WriteLine("*******************************************************");
                Console.WriteLine("");

                //llamamos al metodo para recorrer el arbol del directorio

                RecorrerArbol(directorioRaiz);

                Console.WriteLine("Pulse cualquier tecla para continuar...");
                Console.ReadLine();
            }


       // }

        static void RecorrerArbol(System.IO.DirectoryInfo raiz)
        {
            System.IO.FileInfo[] archivos = null;
            System.IO.DirectoryInfo[] subCarpetas = null;

            //primero procesamos los archivos de la carpeta pasada 

            try
            {
                archivos = raiz.GetFiles("*.*");
            }
            //esta excepcion se producira aunque solo uno de los archivos
            catch (UnauthorizedAccessException e)
            {
                log.Add(e.Message);
            }

            //se produce si alguna de las subcarpetas no esta accesible o carecemos de los permisos requeridos

            catch (System.IO.DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            //si hemos podido leer la lista de archivos 

            if (archivos != null)
            {
                foreach (System.IO.FileInfo informacionArchivo in archivos)
                {
                    Console.WriteLine(informacionArchivo.FullName);
                }

                subCarpetas = raiz.GetDirectories();

                foreach (System.IO.DirectoryInfo informacionCarpeta in subCarpetas)
                {
                    //Mostramos el nombre de la carpeta en curso
                    Console.WriteLine("\n" + informacionCarpeta.FullName);
                    //LLAMADA recursiva a este mismo metodo para la subcarpeta

                    RecorrerArbol(informacionCarpeta);
                }
            }
        }
    }

}

