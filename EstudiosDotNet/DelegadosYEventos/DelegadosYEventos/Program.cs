using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegadosYEventos
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria Cuenta = new CuentaBancaria();
            Cuenta.Apuntador = notificar;
            //Cuenta.Apuntador += notificar; //almacena en direccion dos veces
            Console.WriteLine(Cuenta.Depositar(1000));
            Console.WriteLine(Cuenta.Retirar(500));
            Console.WriteLine(Cuenta.Retirar(250));
            Console.WriteLine(Cuenta.Retirar(500));
            Console.WriteLine(Cuenta.Retirar(250));

            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadLine();
        }

        static void notificar(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }
}
