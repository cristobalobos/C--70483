using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{

    public class Cliente {
        public int ID { get; set; }
        public string Nombre { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Cliente> clientes = new Dictionary<int, Cliente>();

            Cliente juana = new Cliente { ID = 0, Nombre = "Juana" };
            Cliente josé = new Cliente { ID = 1, Nombre = "Jose" };

            clientes.Add(juana.ID, juana);
            clientes[josé.ID] = josé;
            

            foreach (int clave in clientes.Keys) Console.WriteLine(clientes[clave].Nombre);

            Dictionary<int, Cliente> clientes2 = new Dictionary<int, Cliente> {
                [0] = new Cliente { ID = 0, Nombre = "Christina" },
                [1] = new Cliente { ID = 0, Nombre = "Alejandro" }
            };

            foreach (int clave in clientes2.Keys) Console.WriteLine(clientes2[clave].Nombre);
            Console.ReadLine();


        }
    }
}
