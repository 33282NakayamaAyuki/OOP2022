using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    public static class InchConverter {
        private const double ratio = 0.0254;

        public static double ToMeter(double inch)
        {
            return ratio * inch;
        }
    }
}
