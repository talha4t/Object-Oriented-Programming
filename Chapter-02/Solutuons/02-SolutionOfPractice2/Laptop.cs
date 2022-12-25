using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_SolutionOfPractice2
{
    internal class Laptop
    {
        public string brandName;
        public int ramInSize;
        public int numberOfCore;

        public string GetInfoWeatherItsGoodForProgrammer()
        {
            if (ramInSize >= 8 && numberOfCore >= 7)
            {
                return "This laptop is appropriate for a programmer";
            }
            else
            {
                return "Laptop with this configuration is not appropriate for a programmer";
            }
        }
    }
}
