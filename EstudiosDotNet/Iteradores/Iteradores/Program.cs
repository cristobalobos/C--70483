using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Iteradores
{   
    class Matriz<T> : IEnumerable<T> 
    {
        //definición de la interface
        public static T[] matriz;
        public Matriz(int elementos) { matriz = new T[elementos]; }
        public void Asignar(int i, T elemento) { matriz[i] = elemento; }
        public System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < matriz.Length; i++)
            {
                yield return matriz[i];
            }
        }
        //El metodo no generico que precisa el sistema hace la llamada al generico anterior

        IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }

        //otra forma de implementarlo con una ordenación inversa
        public IEnumerable<T> Descendente
        {
            get
            {

                for (int i = matriz.Length - 1; i >= 0; i--)
                {
                    //se puede implementar varios yeuld en el mismo metodo
                    yield return matriz[i];
                    yield return matriz[i];
                }

            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Matriz<int> matriz;
            Matriz<string> matrizCadena;
            while (true)
            {
                Console.WriteLine("\n Indique el numero de elmentos que desea tratar o 0 para salir");
                int elementos;
                bool correcto = Int32.TryParse(Console.ReadLine(), out elementos);

                if (elementos == 0) break;
                else
                {
                    matriz = new Matriz<int>(elementos);
                    matrizCadena = new Matriz<string>(elementos);
                    //Alimentamos las matrices
                }

                for (int i = 0; i < elementos; i++)
                {
                    matriz.Asignar(i, i + 1);
                    matrizCadena.Asignar(i, "Elemento: " + (i + 1).ToString());
                }
                //Recorremos la numera de forma ascendente con el GetEnumerator

                Console.WriteLine("\n Ascendente");

                foreach (int numero in matriz) Console.WriteLine(numero);
                //Recorremos la de cadena descente con el metodo
                Console.WriteLine("\n Descendente ");
                foreach (string numero in matrizCadena.Descendente) {
                    Console.WriteLine(numero);
                }


            }

        }
    }
}







