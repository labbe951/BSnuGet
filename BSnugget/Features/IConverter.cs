using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSnugget.Features
{
    public interface IConverter
    {
        double ConvertKgToLbs(double kg);
        double ConvertKgToStone(double kg);
        double ConvertLbsToKg(double lbs);
        double ConvertStoneToKg(double stone);
    }
}
