using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace Final_project
{
    class Menu
    {
        static List<Sushi> sushiMenu = new List<Sushi>()
            {
                new Sushi {ID = 1, Name = "Philapelphia", Price = 14.50 },
                new Sushi {ID = 2, Name = "California", Price = 13.00 },
                new Sushi {ID = 3, Name = "Shrimp Roll", Price = 14.00 },
                new Sushi {ID = 4, Name = "Eel Roll", Price = 11.50 },
                new Sushi {ID = 5, Name = "Avocado Roll", Price = 10.00 }
            };

        List<Sushi> order = new List<Sushi>();

        public void DisplaySushiList()
        {
            Console.WriteLine("{0,-10} {1,-15} {2,0}\n", "No", "Name", "Price in BYN:");

            foreach (var roll in sushiMenu)
            {
                Console.WriteLine("{0,-8} {1,-20} {2,0}", roll.ID, roll.Name, roll.Price);
            }
        }

        public void SelectItems()
        {
            string userInput = Console.ReadLine();
            int itemNum;
            
            if (int.TryParse(userInput, out itemNum) && sushiMenu.Exists(x => x.ID == itemNum))
            {
                Sushi selectedSushi = sushiMenu.Find(x => x.ID == itemNum);
                order.Add(new Sushi { ID = selectedSushi.ID, Name = selectedSushi.Name, Price = selectedSushi.Price });
            }
            else
            {
                Console.WriteLine("Incorrect value. Please, try again");
            }
        }

        public List<Sushi> ShowSelectedItems()
        {
            Console.WriteLine("You ordered:");

            foreach (var roll in order)
            {
                Console.WriteLine("{0,-8} {1,-20} {2,0}", roll.ID, roll.Name, roll.Price);
            }
            return order;
        }

        double TotalPrice { get; set; }

        public double CalculatePayment()
        {
            foreach (Sushi item in order)
            {
                TotalPrice += item.Price;
            }
            return TotalPrice;
        }
    }
}


