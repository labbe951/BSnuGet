using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSnugget.Features
{
    public class ConverterFactory 
    {
        public IConverter GetConverter(string converterName) 
        {
            switch (converterName)
            {
                case "Converter":
                return new Converter();
                default: throw new Exception();  
            }
        }
    }
}
