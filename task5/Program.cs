using System.Security;
using System.Transactions;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Group group1 = new Group("P234",6);
            Student student1 = new Student("Orxan", "Aslanov", group1.GroupNumber);
            Student student2 = new Student("Orxan", "Aslanov", group1.GroupNumber);
            Student student3 = new Student("Orxan", "Aslanov", group1.GroupNumber);
            Student student4 = new Student("Orxan", "Aslanov", group1.GroupNumber);
            Student student5 = new Student("Orxan", "Aslanov", group1.GroupNumber);
            Student student6 = new Student("Orxan", "Aslanov", group1.GroupNumber);

            group1.AddStudent(student1);
            group1.AddStudent(student2);
            group1.AddStudent(student3);
            group1.AddStudent(student4);
            group1.AddStudent(student5);
            group1.AddStudent(student6);


            group1.GetStudent();
        }
    }
}