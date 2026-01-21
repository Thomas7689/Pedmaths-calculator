using ConsoleApp1.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.View
{

    enum mainMenu
    {
        Enter_new_equation = 1, 
        Exit
    }

    enum newEq
    {
        Please_enter_your_new_equation_bellow = 1,
        Enter_0_to_cancel
    }

    internal class view
    {

        public void DisplayMenu()
        {
            Console.Clear();
            foreach (var item in Enum.GetValues(typeof(mainMenu)))
            {
                Console.WriteLine($"{(int)item}. {item.ToString().Replace("_", " ")}");
            }


            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:

                    newEquation();


                    break;
                case 2:

                    Console.Clear();
                    Console.WriteLine("Exiting math calculation. Have a good day!");
                    Task.Delay(2000).Wait();
                    Environment.Exit(0);

                    break;
                default:

                    Console.Clear();
                    Console.WriteLine("Please enter a valid choice. Returning to main Menu");
                    Task.Delay(2000).Wait();
                    DisplayMenu();

                    break;
            }



        }


        public void newEquation()
        {

            Console.Clear();

            foreach (var item in Enum.GetValues(typeof(newEq)))
            {
                Console.WriteLine($"{item.ToString().Replace("_", " ")}");
            }

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "0":

                    Console.Clear();
                    Console.WriteLine("Returning to main menu");
                    Task.Delay(2000).Wait();
                    DisplayMenu();

                    break;
                default:

                    MathController eq = new MathController();
                    eq.equationController(choice);

                    break;
            }


        }


    }
}
