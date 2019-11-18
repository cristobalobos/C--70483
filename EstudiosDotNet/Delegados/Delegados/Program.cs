using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    class Program
    {
        public delegate void delegado(string mensaje);

        static void Main(string[] args)
        {
            delegado unDelegado = new delegado(metodoDelegado);
            delegado versionCharp = metodoDelegado;
            delegado viaMetodoAnonimo = delegate (string mensaje) { Console.WriteLine(mensaje); };
            delegado viaExpresionLambda = mensaje => { Console.WriteLine(mensaje); };

            unDelegado("Este es el mensaje que se mostrara");
            versionCharp("este mensaje tambien");
            metodoConRetorno("Antonio","Palomares","Sender",versionCharp);
        }

            //mensaje con la misma firma que el delegado
        static void metodoDelegado(string mensaje) {
            Console.WriteLine(mensaje);
        }

        private static void metodoConRetorno(string nombre, string apellido1, string apellido2, delegado retorno)
        {
            retorno(apellido1 + " " + apellido2 + ", " + nombre);            
        }

    }
}
