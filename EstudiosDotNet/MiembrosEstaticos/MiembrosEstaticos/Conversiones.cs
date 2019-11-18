using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiembrosEstaticos
{
   static class Conversiones
    {
        public static double ConvertirLibrasAKilogramos(double libras) {
            return libras * 0.4512554;
        }

        public static string ClaveEncriptada
        {
            get; set;
        }

        public static void DesEncripta() { }
    }
}
