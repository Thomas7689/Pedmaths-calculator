using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            View.view display = new View.view();

            display.DisplayMenu();


            Console.ReadLine();

        }
    }
}
