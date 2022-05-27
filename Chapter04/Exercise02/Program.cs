using Exercise01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args)
        {
            //4.2.1

            var ymCollection = new YearMonth[] {
                new YearMonth(1999,5),
                new YearMonth(2000,3),
                new YearMonth(2001,12),
                new YearMonth(2010,1),
                new YearMonth(2020,7),
            };

            //4.2.2
            Exercise2_2(ymCollection);
            Console.WriteLine("---------");

            ////4.2.4
            Exercise2_4(ymCollection);
            Console.WriteLine("---------");

            ////4.2.5
            Exercise2_5(ymCollection);
            Console.WriteLine("---------");

            Exercise2_6(ymCollection);

            #region
            //var ym = new YearMonth(2022, 5);

            //var check = ym.Is21Century;
            //var test = ym.AddOneMonth();

            //Console.WriteLine(ym);
            #endregion
        }

        private static void Exercise2_6(YearMonth[] ymCollection)
        {
            
            foreach (var ym in ymCollection.OrderByDescending(ym => ym.Year))
            {
                Console.WriteLine(ym);
            }

        }

        ////4.2.3
        static YearMonth FindFirst21C(YearMonth[] yms)
        {
            foreach (var ym in yms)
            {
                if (ym.Is21Century)
                {
                     return ym;
                }
            }
            return null;
        }

        //4.2.2
        private static void Exercise2_2(YearMonth[] ymCollection)
        {
            //var output = ymCollection.Select(n => n);
            //var ascending = ymCollection.OrderBy(n => n.Year);昇順で出す

            foreach (var ym in ymCollection)
            {
                Console.WriteLine(ym);
            }
        }

        ////4.2.4
        private static void Exercise2_4(YearMonth[] ymCollection)
        {

            var yearmonth = FindFirst21C(ymCollection);
            if (yearmonth != null ) {
                Console.WriteLine(yearmonth);
            } else {
                Console.WriteLine("21世紀のデータはありません");
            }
        }

        ////4.2.5
        private static void Exercise2_5(YearMonth[] ymCollection)
        {
            var array = ymCollection.Select(ym => ym.AddOneMonth()).ToArray();
            foreach (var ym in array)
            {
                Console.WriteLine(ym);
            }
        }
    }
}
