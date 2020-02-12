using System;
using System.Collections.Generic;
using System.Text;

namespace Final_project
{
    class Order
    {
        Menu menu = new Menu();
        public void SelectItems()
        {
            string userInput = Console.ReadLine();
            int itemNum;
            List<Sushi> order = new List<Sushi>();
            if (int.TryParse(userInput, out itemNum) && menu.sushiMenu.Exists(x => x.ID == itemNum))
            {

                order.Add(new Sushi());
                foreach (var roll in order)
                {
                    Console.WriteLine("{0,-8} {1,-20} {2,0}", roll.ID, roll.Name, roll.Price);
                }
            }
            else
            {
                Console.WriteLine("Incorrect value. Please, try again");
            }
        }
    }
}
