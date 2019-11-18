using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesYMiembros
{
    class Program
    {
        static void Main(string[] args)
        {
            Automovil auto = new Automovil("Europa"); //creamos el objeto en memoria, se esta haciendo una referencia
                        
            auto.Color = "Verde Botella";
            auto.Marca = "VM";
            auto.Modelo = "Europa";
            auto.Arrancar();
            auto.GasolinaAgotada += Auto_GasolinaAgotada;
        }

        private static void Auto_GasolinaAgotada(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
