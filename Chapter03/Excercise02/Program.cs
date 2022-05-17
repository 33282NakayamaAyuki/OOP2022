using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise02 {
    class Program {
        static void Main(string[] args)
        {
            var names = new List<string> {
               "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };

            Exercise2_1(names);
            Console.WriteLine("---------");

            Exercise2_2(names);
            Console.WriteLine("---------");

            Exercise2_3(names);
            Console.WriteLine("---------");

            Exercise2_4(names);
            Console.WriteLine("---------");
        }

        private static void Exercise2_1(List<string> names)
        {
            Console.WriteLine("都市名を入力。空行で終了");
            do
            {
                var line = Console.ReadLine();
                if (string.IsNullOrEmpty(line))
                    break;
                    
                var index = names.FindIndex(n => n == line); 
                Console.WriteLine(index);
                

            } while (true);
        }

        private static void Exercise2_2(List<string> names)
        {
             var count = names.Count(n => n.Contains("o"));
             Console.WriteLine(count + "都市");
        }

        private static void Exercise2_3(List<string> names)
        {
            var list = names.Where(n => n.Contains("o")).ToList();
            foreach (var n in list) 
            {
                Console.WriteLine(n);
            }
        }

        private static void Exercise2_4(List<string> names)
        {
            var Bcity = names.Where(s => s.StartsWith("B")).Select(s => s.Length);
            foreach (var s in Bcity)
            {
                Console.WriteLine(s);
            }
        }
    }
}
