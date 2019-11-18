using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vectores
{
    class MiVector<T> : System.Collections.IEnumerable
    {
        private T[] _vector;
        private string _nombre;
        public MiVector(int elementos,string nombre)
        {
            _vector = new T[elementos];
            _nombre = nombre;
        }

        public T this[int indice]
        {
            get { return _vector[indice]; }
            set { _vector[indice] = value; }
        }


        public string Nombre
        {
            get
            {
                return _nombre;
            }

          }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _vector.Length; i++)
                yield return _vector[i];
        }
    }
}