using System;

namespace Final_project
{
    class ClientInfo
    {
        public event Action UserDetailFilledIn;

        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public string GetName()
        {
            Console.WriteLine("Name: ");
            Name = Console.ReadLine();
            return Name;
        }

        public string GetAddress()
        {
            Console.WriteLine("Address: ");
            Address = Console.ReadLine();
            return Address;
        }

        public void CheckIfInfoFilledIn()
        {
            if (Name != null && Address != null)
            {
                UserDetailFilledIn?.Invoke();
            }
            else
            {
                Console.WriteLine("wrong data");
            }
        }
    }
}
