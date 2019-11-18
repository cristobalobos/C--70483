using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yield
{
    class PruebaDiasDeLaSemana
    {
        public class DiasDeLaSemana : IEnumerable
        {

            private string[] _dias = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };

            public System.Collections.IEnumerator GetEnumerator()
            {
                for (int i = 0; i < _dias.Length; i++)
                {
                    yield return _dias[i];

                }

            }


            public class PruebaDiasDeLaSemana
            {
                static void Main ()
                {
                    DiasDeLaSemana semana = new DiasDeLaSemana();

                    foreach (string dia in semana)
                    {
                        System.Console.WriteLine(dia + "");
                    }
                    Console.ReadLine();
                }
            }


        }

    }
}
