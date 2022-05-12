using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    public class Program {
        static void Main(string[] args)
        {
            PrintMeterToInchList(1, 10);
        }

        private static void PrintMeterToInchList(int start, int stop)
        {
            //FeetConverter feetconverter = new FeetConverter();
            for (int inch = start; inch <= stop; inch++)
            {
                double meter = InchConverter.ToMeter(inch);
                Console.WriteLine("{0} inch = {1:0.0000} m", inch, meter);
            }
        }
    }
}
