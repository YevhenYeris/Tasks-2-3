using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Group
    {
        protected string name = "";
        protected List<Student> students = new List<Student>();
        public List<Student> Students => students;


        public Group(string name)
        {
            this.name = name;
        }

        public void AddStudent(Student st)
        {
            students.Add(st);
        }

        public void GetInfo()
        {
            Console.WriteLine("Група " + name);
            Console.WriteLine("Студенти: ");

            foreach (var st in students) {
                Console.WriteLine(st.Name);
            }
            Console.WriteLine();
        }


        public void GetFullInfo()
        {
            Console.WriteLine("Група " + name);
            Console.WriteLine("Студенти: ");

            foreach (var st in students)
            {
                Console.WriteLine("{0} - {1}", st.Name, st.State);
            }
            Console.WriteLine();
        }
    }
}
