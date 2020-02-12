using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
//using System.Text.Json;
//using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Final_project
{
    class Menu
    {
        public void GetSushiList()
        {
            List<Sushi> sushiMenu = new List<Sushi>()
            {
                new Sushi {ID = 1, Name = "Philapelphia", Price = 14.50 },
                new Sushi {ID = 2, Name = "California", Price = 13.00 },
                new Sushi {ID = 3, Name = "Shrimp Roll", Price = 14.00 },
                new Sushi {ID = 4, Name = "Eel Roll", Price = 11.50 },
                new Sushi {ID = 5, Name = "Avocado Roll", Price = 10.00 }
            };

            Console.WriteLine("{0,-10} {1,-15} {2,0}\n", "No", "Name", "Price in BYN:");

            foreach (var roll in sushiMenu)
            {
                Console.WriteLine("{0,-8} {1,-20} {2,0}", roll.ID, roll.Name, roll.Price);
            }
        }
    }
}
