using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    internal class Student
    {
        public string Name;
        public string Surname;
        public Group Group;

        public Student(string name, string surname,int group)
        {
            Name = name;
            Surname = surname;
            Group = group;

        }
    }
}
