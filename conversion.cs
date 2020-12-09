using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temp
{
    public class conversion
    {
        //pure methods
        public string FahToCel(string Fah)
        {

            Single Fahrenheit = Convert.ToSingle(Fah);
            Single Celsius = (float)((5.0 / 9.0) * (Fahrenheit - 32.0));
            return Celsius.ToString();



        }
        public string CelToFah(string cel)
        {

            Single Celsius = Convert.ToSingle(cel);
            Single Fahrenheit = (float)(Celsius * (9.0 / 5.0) + 32); 
            return Fahrenheit.ToString();



        }




    }
}
