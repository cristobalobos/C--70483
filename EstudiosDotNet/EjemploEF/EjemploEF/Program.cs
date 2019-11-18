using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploEF
{
    class Program
    {
        static void Main(string[] args)
        {

            CodigoViejo();

            using (SchoolDBEntities db = new SchoolDBEntities())
            {
                Console.WriteLine("Que ID quiere modificar??");
                string sID = Console.ReadLine();
                int id = int.Parse(sID);

                var q = from stud in db.Student
                        where stud.Id == id
                        select stud;
                //tipo anonimo
//                select new { stud.FirstName, stud.LastName };

                //cuando es tipo anonimo se cambia a VAR
                Student student = q.FirstOrDefault();

                if (student == null)
                {
                    Console.WriteLine("No existe");
                }
                else
                {
                    Console.WriteLine("El Apellido es"+student.LastName 
                        + "\n Cual es el nuevo apelido");
                    string nuevoApellido = Console.ReadLine();
                    student.LastName = nuevoApellido;
                    db.SaveChanges();
                }


            }


            Console.ReadLine();
        }

        private static void CodigoViejo()
        {/*
            //db context
            using (SchoolDBEntities db = new SchoolDBEntities())
            {
                //foreach (Student s in db.Student)
                //{
                //    Console.WriteLine(s.FirstName + " " + s.LastName);
                //}

                var q = from alumno in db.Student
                        where alumno.LastName.StartsWith("L")
                        orderby alumno.LastName
                        select alumno;
                List<Student> lista = q.ToList();

                lista = (from l in lista
                         where l.LastName.StartsWith("l")
                         select l).ToList();



                Console.WriteLine(q);
                foreach (Student s in q)
                {
                    Console.WriteLine(s.FirstName + " " + s.LastName);

                }
           
            }
       */
        }
    }
}
