using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploEF
{
    partial class Student
    {
        public string NombreCopleto
        {
            get { return FirstName; }
        }
    }
}
