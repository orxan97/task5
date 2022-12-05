using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Group
    {
        public string GroupNumber;
        public byte Limit;
        public static Student[] Students;


        public Group(string groupnumber,byte limit)
        {
            GroupNumber = groupnumber;
            Limit = limit;
            Students = new Student[0];

        }
        public void AddStudent(Student student)
        {
            if (Students.Length<=Limit-1)
            {
                Array.Resize(ref Students, Students.Length+1);
                Students[Students.Length - 1] = student;
            }

        }
        public void GetStudent()
        {
            foreach (var item in Students)
            {
                Console.WriteLine($"{item.Name}  {item.Surname} = {item.Group}");
            }

        }
    }
}
