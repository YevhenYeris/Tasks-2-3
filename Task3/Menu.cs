using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Menu
    {
        private Converter _converter;
        public Menu(Converter conv)
        {
            _converter = conv;
        }

        public void Exchange()
        {
            string from = "";
            string to = "";
            double value = 0;

            Console.WriteLine("Конвертувати з: ");
            from = Console.ReadLine();

            Console.WriteLine("Конвертувати в: ");
            to = Console.ReadLine();

            Console.WriteLine("Введiть суму: ");
            value = double.Parse(Console.ReadLine());

            Console.WriteLine(_converter.Convert(from, to, value));
        }
    }
}
