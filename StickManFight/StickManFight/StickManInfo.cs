using System;

namespace StickManFight
{
    public abstract class StickManInfo
    {
        //Properties
        public string Name { get; set; }

        public string Nationality { get; set; }

        //Metode
        //Returnerer en informationsstreng med navn og nationalitet
        public string GenerateInfo()
        {
            return string.Format("{0} from {1}", Name, Nationality);
        }


    }
}
