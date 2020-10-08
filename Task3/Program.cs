using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu(new Converter(28.1825, 32.8429));

            menu.Exchange();
        }
    }
}
