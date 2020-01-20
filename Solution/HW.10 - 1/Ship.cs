using System;
using System.Collections.Generic;
using System.Text;

namespace HW._10___1
{
    public class Ship
    {
        public int Draft;
        public int Crew;

        public Ship(int draft, int crew)
        {
            Draft = draft;
            Crew = crew;
        }

        public bool IsWorthIt(int draft, int crew)
        {
            double crewWeight = crew * 1.5;
            double draftWithoutCrew = draft - crewWeight;

            if(draftWithoutCrew > 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
