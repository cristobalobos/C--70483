using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atributos
{
    //Aqui limitamos , mediante atributos , el uso de nuestro atributo solo con clases y estructuras
    //y permitimos que se pueda utilizar varias veces en cada uso
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true)]
    public class Autor : Attribute
    {
        public string _nombre;
        //Al ser de acceso publico se convierte en un parametro con nombre de atributo
        public double version;
        //Al ser parametro del constructor se convierte en parametro posicional y obligatorio del atributo

        public Autor(string nombre) {
            _nombre = nombre;
            version = 1.0;
        }

    }

    [Autor("MSDN",version =1.0)]
    [Autor("Antonio",version =2.0)]
    class Program
    {
        static void Main(string[] args)
        {
            //.........

        }
    }
}
