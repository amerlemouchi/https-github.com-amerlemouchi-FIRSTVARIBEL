using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_FloatPointType
{
    class Program
    {
        static void Main(string[] args)
        {
            float flMin = float.MinValue;
            float flMax = float.MaxValue;

            Console.WriteLine("Min value = {0} Max walue = {1} ", flMin , flMax );

            float flVar = 1F/ 3;

            double dlVar = 1D / 3;

            decimal dcVar = 1M / 3;

            Console.WriteLine("\nflaot Value = {0}\ndoubel Value = {1}\ndecimal Value = {2}", flVar , dlVar , dcVar );
             
            Console.ReadKey();
        }




    }
}



