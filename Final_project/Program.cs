using System;
using System.Net.Mail;

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

            do
            {
                Console.WriteLine("Enter number of roll you'd like to order.");
                menu.SelectItems();
                menu.ShowSelectedItems();
                Console.WriteLine("Would you like to order anything else? Enter Yes/No");
            }
            while (Console.ReadLine().ToLower() == "yes");

            menu.CalculatePayment();
            



            Console.WriteLine("Please, fill in the form below to checkout");

            ClientInfo client = new ClientInfo();
            Mailer mailer = new Mailer();
            
            client.UserDetailFilledIn += mailer.SendMailUponOrderPlacement;

            client.GetName();
            client.GetEmail();
            client.GetAddress();

            
            //mailer.SendMailUponOrderPlacement();


        }
    }
}
