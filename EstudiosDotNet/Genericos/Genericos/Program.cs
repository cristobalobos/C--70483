using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genericos
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList {1,3,5,7};
            a1.Add("Hello");
            a1.Add(20); //Boxin
            int i = (int)a1[0];//unboxin

            
            List<int> Enteros = new List<int> {8, 3, 5, 7 };

            Enteros.Sort();

            ListGenerica<string> MiListaGenerica;
            ListGenerica<Empleado> empleado;             
        }

        class Empleado { }
    }
}
