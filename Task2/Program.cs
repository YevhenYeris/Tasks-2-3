using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Group K220 = new Group("K-220");

            K220.AddStudent(new GoodStudent("Iван Iваненко"));
            K220.AddStudent(new GoodStudent("Василь Василецький"));
            K220.AddStudent(new BadStudent("Олег Олежчук"));
            K220.AddStudent(new GoodStudent("Петро Петров"));

            K220.GetInfo();
            K220.GetFullInfo();

            Console.ReadKey();

            GoodStudent stGood = new GoodStudent("Євген Хороший");
            stGood.Study();
            Console.WriteLine();

            Console.ReadKey();

            BadStudent stBad = new BadStudent("Євген Поганий");
            stBad.Study();
        }
    }
}
