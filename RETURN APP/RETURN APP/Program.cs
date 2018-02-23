using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RETURN_APP
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = 5;
            Student Hesabla()
            {
                return new Student("Murad");

            }
            Console.WriteLine(Hesabla().Surname);
        
        }
    }
    class Student
    {
        
        public string Surname;
    

        public Student(string _surname)
        {
            
            Surname = _surname;

        }
    }
}
