using System;

namespace Final_project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Sushi inc. Press any key to open menu.\n");
            Console.ReadKey();

            Menu menu = new Menu();
            menu.DisplaySushiList();

            Console.WriteLine("Enter number of roll you'd like to order.");

            //Order order = new Order();
            menu.SelectItems();
        }
    }
}
