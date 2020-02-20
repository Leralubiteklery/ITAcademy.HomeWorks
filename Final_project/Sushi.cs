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
    
