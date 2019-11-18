using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesStudio
{
    class Program
    {
        static void Main(string[] args)
        {

            Operaciones<Oficinista> o = new Operaciones<Oficinista>();
            Demo<GerenteVentas, Gerente> d;
            //viene con constructor, ya que no existe uno predeterminado en la clase
            Demo2<Gerente> d2;

            Demo5<GerenteVentas, persona> d5;




            Gerente g = new Gerente();
            IEmpleado ie = new Gerente();
            IEmpleado g3 = g;
            g = (Gerente)g3;
            g = g3 as Gerente;
            ImprimeDatos(g);
            ImprimeDatos(ie);
            var o = new Oficinista();
            ImprimeDatos(o);

            var os = new obreroSindicalizado();
            ISindicalizado ios = new obreroSindicalizado();

        }

        static void ImprimeDatos(IEmpleado empleado) {
            Console.WriteLine($"{empleado.nombre} {empleado.apellido}" );
        }

        struct persona { }
    }
}
