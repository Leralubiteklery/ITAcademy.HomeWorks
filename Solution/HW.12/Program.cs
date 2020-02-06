using System;
using System.Collections.Generic;

namespace HW._12
{
    class Program
    {
        public static List<Moto> motorcycles = new List<Moto> { };
        static void Main(string[] args)
        {
            Logger.InitLogger();
            Logger.Log.Info("Starting application");
            CRUDClass crud = new CRUDClass();

            crud.CreateMotorcycle();
            crud.DeleteMotorcycle(motorcycles);
            crud.GetMotorcycleByID(motorcycles);
            crud.GetMotorcycles(motorcycles);
            crud.UpdateMotorcycle();
        }
    }
}
