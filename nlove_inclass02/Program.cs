using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nlove_inclass02
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("00011", "Natasha", "S", "Love", 30);
            Console.WriteLine (s.DisplayInformation());

            Console.WriteLine();
            Console.WriteLine("Press any key to exit..");
            Console.ReadKey();
        }
    }
}
