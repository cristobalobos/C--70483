using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Derivada d = new Derivada();
            Base b = d as Base;

            if (b != null) {
                Console.WriteLine(b.ToString());
            }

            Console.ReadLine();



        }
    }
}
