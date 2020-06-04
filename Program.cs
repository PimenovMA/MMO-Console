using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMO_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // var name = "";
            Console.WriteLine("Привет программа!");
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет {name}");
        }
    }
}
