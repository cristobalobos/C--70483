using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiembrosEstaticos
{
    class Program
    {

        static void Main(string[] args)
        {
            var Kilos =
                Conversiones.ConvertirLibrasAKilogramos(200);

             

            Conversiones.ClaveEncriptada = "123";
        }
    }
}
