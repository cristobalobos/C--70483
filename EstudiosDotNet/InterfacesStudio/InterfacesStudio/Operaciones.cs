using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesStudio
{

    //Registriccion donde recibe un generico, y T tiene como clase derivada Ofinista
    //Oficinista al tener un Interface puede utilizar la clase los elementos en su contructor
    class Operaciones<T> where T : Oficinista
    {
        T empleado;
        public Operaciones()
        {
            empleado.SueldoDiario = 0;
        }

    }

    // Donde T debe ser clase derivada y U la base
    class Demo<T, U> where T : U { }

    class GerenteVentas : Gerente
    {
    }
    //Donde se define un constructor por defecto
    class Demo2<T> where T : new()
    { }

    //Solamente de tipo por valor
    class Demo3<T> where T : struct { }
    
    //solamente del tipo por referencia
    class Demo4<T> where T : class { }
    
    // U debe ser derivado de un struct y T de un gerente y con constructor
    class Demo5<T, U> where U : struct
                    where T : Gerente, new()
    { }

}
