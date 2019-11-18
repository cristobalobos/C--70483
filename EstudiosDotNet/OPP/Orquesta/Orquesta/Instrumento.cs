using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orquesta
{
    public abstract class Instrumento
    {

        #region atributos
        private int _tempo;
        private int _volumen;
        private string _nombre;
        #endregion
        #region constructor
        public Instrumento (string nombre) {
            _nombre = nombre;
            Situado = true;
            Interpretando = false;
            Afinando = false;
        }
        #endregion

        #region propiedades
        public int Tempo
        {
            set
            {
                _tempo += value;
                if (_tempo < 0) {
                    _tempo = 0;                        
                   
                 }
            }


            get
            {
                return _tempo;
            }
            
        }

        public int Volumen
        {
            set
            {

                _volumen += value;
                if (_volumen < 0)
                {
                    _volumen = 0;
                }
                
            }

            get
            {
                return _volumen;
            }
        }


        public string Nombre {
            get { return _nombre; }
        }

        public bool Situado {
            get; set;    
        }
        public bool Interpretando
        {
            get; set;
        }

        public bool Afinando
        {
            get; set;
        }
        #endregion
        #region Metodo
        public abstract void Afinar();

        public void Intepretar(int tempo, int volumen) {
            _tempo = tempo;
            _volumen = volumen;

            Interpretando = true;
        }

        public void Parar() {
            _tempo = 0;
            _volumen = 0;

            Interpretando = false;
            Afinando = false;
        }
        #endregion
    }
}
