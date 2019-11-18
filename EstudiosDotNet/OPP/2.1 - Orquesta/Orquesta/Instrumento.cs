using System;
using System.Text;

namespace Orquesta 
{
    /// <summary>
    /// Clase base para toda la orquestra
    /// </summary>
    public abstract class Instrumento
    {
        #region Atributos
        private int _tempo;
        private int _volumen;
        private bool _situado;
        private bool _interpretando = false;
        private bool _afinando = false;
        private string _nombre;
        #endregion

        #region Propiedades
        public int Tempo  {
            get { return _tempo; }
            set { _tempo += value;
                  if (_tempo < 0) _tempo = 0; }
        }
        public int Volumen  {
            get { return _volumen; }
            set { _volumen += value;
                  if (_volumen < 0) _volumen = 0; }
        }
        public bool Situado
        {
            get { return _situado; }
            set { _situado = value; }
        }
        public bool Afinando
        {
            get { return _afinando; }
            set { _afinando = value; }
        }
        public bool Interpretando
        {
            get { return _interpretando; }
            set { Interpretando = value; }
        }
        public string Nombre {
            get { return _nombre; }
        }
        #endregion

        #region Constructor
        public Instrumento(string Nombre)  {
            _nombre = Nombre;
            Situado = true;
        }
        #endregion

        #region Métodos
        public abstract void Afinar();
        public void Interpretar(int tempo, int volumen)  {
            _tempo = tempo;
            _volumen = volumen;
            _interpretando = true;
        }
        public void Parar()  {
            _interpretando = false;
            _afinando = false;
            _tempo = 0;
            _volumen = 0;
        }
        #endregion
    }
}
