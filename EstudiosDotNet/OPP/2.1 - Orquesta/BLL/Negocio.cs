using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using ModeloDatos;
namespace BLL
{
    public class Negocio
    {
        static List<Instrumento> Orquesta;

        public List<Instrumento> InicializarOrquesta()
        {
            Repositorio datos = new Repositorio();
            Orquesta = datos.InicializarOrquesta();
            return Orquesta;
        }

        public void TransportarInstrumentos()
        {
            foreach (Instrumento instrumento in Orquesta)
                if ((instrumento) is ITransportar)
                {
                    ITransportar transportable = (ITransportar)instrumento;
                    transportable.Transportar();
                }
        }

        public void Afinar()
        {
            foreach (Instrumento instrumento in Orquesta)
                instrumento.Afinar();
        }

        public void ComenzarEjecucion(int tempo, int volumen)
        {
            foreach (Instrumento instrumento in Orquesta)
                instrumento.Interpretar(tempo, volumen);
        }

        public void ModificarVolumen(Superclase tipo, int modificador)
        {
            foreach(Instrumento instrumento in Orquesta)
            {
                switch (tipo)
                {
                    case Superclase.Baquetas:
                        if ((instrumento) is Baquetas) instrumento.Volumen = modificador;
                        break;
                    case Superclase.Teclas:
                        if ((instrumento) is Teclas) instrumento.Volumen = modificador;
                        break;
                    case Superclase.Mano:
                        if ((instrumento) is Mano) instrumento.Volumen = modificador;
                        break;
                    case Superclase.ConArco:
                        if ((instrumento) is ConArco) instrumento.Volumen = modificador;
                        break;
                    case Superclase.SinArco:
                        if ((instrumento) is SinArco) instrumento.Volumen = modificador;
                        break;
                    case Superclase.Percusion:
                        if ((instrumento) is Percusion) instrumento.Volumen = modificador;
                        break;
                    case Superclase.Cuerda:
                        if ((instrumento) is Cuerda) instrumento.Volumen = modificador;
                        break;
                    case Superclase.Viento:
                        if ((instrumento) is Viento) instrumento.Volumen = modificador;
                        break;
                }
            }
        }

        public void Parar()
        {
            foreach (Instrumento instrumento in Orquesta)
                instrumento.Parar();
        }

        public void ModificarTempo(Superclase tipo, int modificador)
        {
            foreach (Instrumento instrumento in Orquesta)
            {
                switch (tipo)
                {
                    case Superclase.Baquetas:
                        if ((instrumento) is Baquetas) instrumento.Tempo = modificador;
                        break;
                    case Superclase.Teclas:
                        if ((instrumento) is Teclas) instrumento.Tempo = modificador;
                        break;
                    case Superclase.Mano:
                        if ((instrumento) is Mano) instrumento.Tempo = modificador;
                        break;
                    case Superclase.ConArco:
                        if ((instrumento) is ConArco) instrumento.Tempo = modificador;
                        break;
                    case Superclase.SinArco:
                        if ((instrumento) is SinArco) instrumento.Tempo = modificador;
                        break;
                    case Superclase.Percusion:
                        if ((instrumento) is Percusion) instrumento.Tempo = modificador;
                        break;
                    case Superclase.Cuerda:
                        if ((instrumento) is Cuerda) instrumento.Tempo = modificador;
                        break;
                    case Superclase.Viento:
                        if ((instrumento) is Viento) instrumento.Tempo = modificador;
                        break;
                }
            }
        }
    }
}
