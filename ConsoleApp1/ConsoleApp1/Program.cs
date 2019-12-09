using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student("Memmed", "Necefov", 29);
            Student stu2 = new Student("Ismayil", "XXX", 27);
            Student stu3 = new Student("Rafiq", "Qasimov", 22);
            //Console.WriteLine(stu1);
            //Console.WriteLine(stu2.Id);
            //Console.WriteLine(stu3.Id);
            //Person.Hello();

            Group p213 = new Group("p213", 2);
            p213.AddStudent(stu1);
            p213.AddStudent(stu2);
            p213.AddStudent(stu3);

            p213.GetAllStudent();
        }
    }

    #region Static Class
    //static class Person
    //{
    //    public static string Name;

    //    static Person()
    //    {
    //        Console.WriteLine("Salam");
    //    }
    //    public static void Hello()
    //    {
    //        Console.WriteLine("Hello");
    //    }
    //}
    #endregion
}
