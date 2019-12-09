using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        public string Name="Kamran";
        public string Surname;
        public int Age;
        private static int _id = 0;
        public int Id;

        #region static constructor
        //static Student()
        //{
        //    Console.WriteLine("Ilk Telebe yaradildi");
        //}
        #endregion
        public Student(string name,string surname,int age)
        {
            _id++;
            Id = _id;
            Name = name;
            Surname = surname;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Name} {Surname}";
        }

        #region static method
        //public static void Test()
        //{
        //    Console.WriteLine("Salam");
        //}
        #endregion
    }
}
