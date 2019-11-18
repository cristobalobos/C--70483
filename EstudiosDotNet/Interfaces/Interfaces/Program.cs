using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{

    interface IEquatable<T> {
        bool Equals(T parametro);
    }

    class Moto : IEquatable<Moto> {

        private string _marca;
        private string _modelo;

        public string Marca
        {
            get
            {return _marca;}

            set
            { _marca = value;}
        }

        public string Modelo
        {
            get
            {return _modelo;}

            set
            {_modelo = value;}
        }

        //implementas la interface
        public bool Equals(Moto parametro) {
            //if (this.Marca == parametro.Marca && this.Modelo == parametro.Modelo) return true;
            //else return false;

            return this.Marca == parametro.Marca && this.Modelo == parametro.Modelo;
        }

        //Definimos el ToStrig
        public override string ToString()
        {
            return Marca + " " + Modelo;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Moto Primera = new Moto();
            Primera.Marca = "Vespa";
            Primera.Modelo = "Primavera 125";

            Moto Segunda = new Moto();
            Segunda.Marca = "Vespa";
            Segunda.Modelo = "SP 200";
            Moto Tercera = Primera;

            Console.WriteLine(Primera + " == " + Segunda + " -> " + Primera.Equals(Segunda));

            Console.WriteLine(Primera + " == " + Tercera + " -> " + Primera.Equals(Tercera));
            Console.ReadLine();
        }
    }
}
