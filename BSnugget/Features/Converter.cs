using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSnugget.Features
{
    public class Converter : IConverter
    {
        public double ConvertKgToLbs(double kg) 
        {
            double lbs = kg * 2.2046;
            return lbs;
        }

        public double ConvertKgToStone(double kg)
        {
            double stone = kg * 0.15747;
            return stone;
        }

        public double ConvertLbsToKg(double lbs) 
        {
            double kg = lbs / 2.2046;
            return kg;
        }

        public double ConvertStoneToKg(double stone) 
        {
            double kg = stone / 0.15747;
            return kg;
        }

    }
}
