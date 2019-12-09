using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Group
    {
        public int Id;
        private static int _idg = 0;
        public string GName;
        public int MaxStuCount;
        private Student[] AllStu= { };

        public Group(string gname,int count)
        {
            _idg++;
            Id = _idg;
            GName = gname;
            MaxStuCount = count;
        }

        public override string ToString()
        {
            return $"Grup Adi: {GName}, max telebe sayi: {MaxStuCount}";
        }

        public void AddStudent(Student stu)
        {
            if (AllStu.Length < MaxStuCount)
            {
                Array.Resize(ref AllStu, AllStu.Length + 1);
                AllStu[AllStu.Length - 1] = stu;
            }
            else
            {
                Console.WriteLine("Group is full");
            }
        }

        public void GetAllStudent()
        {
            foreach (Student stu in AllStu)
            {
                Console.WriteLine(stu);
            }
        }
    }
}
