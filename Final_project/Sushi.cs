using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Final_project
{
        class Sushi
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }

            public Sushi()
            {
            }
            public Sushi(int id, string name, double price)
            {
                ID = id;
                Name = name;
                Price = price;
            }
        }
}
    
