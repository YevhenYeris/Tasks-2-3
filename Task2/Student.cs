using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    abstract class Student
    {
        protected String name;
        public String Name => name;

        protected String state;
        public String State => state;

        public Student (string name)
        {
            this.name = name;
            this.state = "";
        }
        public void Relax()
        {
            Console.WriteLine("Студент {0} вiдпочиває!", name);
        }

        public void Read()
        {
            Console.WriteLine("Студент {0} читає!", name);
        }

        public void Write()
        {
            Console.WriteLine("Студент {0} пише!", name);
        }

        abstract public void Study();
    }
}
