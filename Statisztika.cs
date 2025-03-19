using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motors
{
    internal class Statisztika
    {
        List<Motor> motors = new List<Motor>();

        public void ReadFromFile(string fileName)
        {
            StreamReader sr = new StreamReader(fileName);
            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] tagok = line.Split(";");
                motors.Add(new Motor(tagok[0], tagok[1], int.Parse(tagok[2]), double.Parse(tagok[3]), double.Parse(tagok[4])));
            }
        }

        public int SumPrices()
        {
            int osszeg = 0;
            for (int i = 0; i < motors.Count; i++)
            {
                osszeg += (int)motors[i].PriceInEur;
            }
            return osszeg;
        }

        public bool Contains(string motorName)
        {
            for (int i = 0; i < motors.Count; i++)
            {
                if (motors[i].Name.Equals(motorName)) { return true; }
            }
            return false;
        }

        public Motor Oldest()
        {
            Motor min = motors[0];
            for (int i = 1; i < motors.Count; i++)
            {
                if (min.ReleaseYear > motors[i].ReleaseYear)
                {
                    min = motors[i];
                }
            }
            return min;
        }

        public int SumBasedOnBrand(string brandName)
        {
            List<Motor> tempMotorok = motors;
            
            for (int i = 0; i < motors.Count; i++)
            {
                if (!(motors[i].Brand.Equals(brandName)))
                {
                    motors.RemoveAt(i);
                }
            }
            int osszeg = SumPrices();

            motors = tempMotorok;
            return SumPrices();
        }

        public void Sort()
        {
            bool marade = true;
            while (marade)
            {
                marade = false;
                for (int i = 0; i < motors.Count-1; i++)
                {
                    if (motors[i].Performance < motors[i + 1].Performance)
                    {
                        marade = true;
                        (motors[i], motors[i + 1]) = (motors[i + 1], motors[i]);
                    }
                }
            }
        }
    }
}
