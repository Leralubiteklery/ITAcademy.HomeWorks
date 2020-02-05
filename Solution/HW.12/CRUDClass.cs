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
        }

        public void GetMotorcycles(List <Moto> motoList)
        {
            foreach(var moto in motoList)
            {
                Console.WriteLine(moto);
            } 
        }

        public void UpdateMotorcycle()
        {

        }



    }
}
