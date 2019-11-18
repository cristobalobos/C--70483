using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace leerArchivo
{
    class Program
    {
        static void Main(string[] args)
        {

            FileStream archivo=null;
            try
            {
                archivo = new FileStream(@"C:\temp\datos.txt", FileMode.Open);

                using (StreamReader lector = new StreamReader(archivo))
                {
                    string linea;
                    do
                    {
                        linea = lector.ReadLine();
                        Console.WriteLine(linea);

                    } while (linea != null);
                    Console.WriteLine("Fin de los datos");
                }

            }
            catch (FileNotFoundException e)
            {
                string error = string.Format("No se encuentra el archivo {0}", archivo);
                Console.WriteLine(error);
                throw new FileNotFoundException(error,e);
            }

            catch (System.IO.IOException e)
            {
                Console.WriteLine(string.Format("Al acceder al archivo {0} se ha producido el error {1}", archivo, e.Message));
            }

            finally
            {
                if (archivo != null) {
                    archivo.Close();
                }

            }


            Console.ReadLine();

        }


    }
}

