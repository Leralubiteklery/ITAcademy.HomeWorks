using System;
using System.Collections.Generic;
using System.Text;

namespace HW._12
{
    class CRUDClass
    {
        private static List<Moto> motoList = new List<Moto>();

        public void CreateMotorcycle()
        {
            Moto newMoto = new Moto();
            motoList.Add(newMoto);
            Logger.Log.Info("Created Moto");
        }

        public void GetMotorcycles(List <Moto> motoList)
        {
            foreach(var moto in motoList)
            {
                Console.WriteLine(moto);
            }
            Logger.Log.Info("Get motorcycles list");
        }

        public void GetMotorcycleByID(List<Moto> motolist)
        {
            Console.WriteLine("Enter ID");
            int id = Convert.ToInt32(Console.ReadLine());

            foreach (var moto in motolist)
            {
                   if(moto.ID == id)
                {
                    Console.WriteLine(moto);
                }             
            }
            Logger.Log.Info("Get motorcycles list by ID");
        }

        public void UpdateMotorcycle()
        {
            Console.WriteLine("Enter extra information about motorcycle");
            Moto newMoto = new Moto();
            newMoto.ExtraInfo = Console.ReadLine();
            Logger.Log.Info("Motorcycle update");
        }

        public void DeleteMotorcycle(List<Moto> motoList)
        {
            foreach(var moto in motoList)
            {
                Console.WriteLine("Enter ID of a motorcycle you want to delete");
                if(moto.ID == Convert.ToInt32(Console.ReadLine()))
                {
                    motoList.Remove(moto);
                }
                else
                {
                    Console.WriteLine("Wrong value");
                }
            }
            Logger.Log.Info("Motorcycle delete");
        }
    }
}
