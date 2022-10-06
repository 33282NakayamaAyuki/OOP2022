using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise１ {
    class Program {
        static void Main(string[] args)
        {
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2()
        {
            var maxpoint = Library.Books
                           .OrderByDescending(b => b.Price)
                           .First()
                           ;
            Console.WriteLine("一番高い金額の書籍は");
            Console.WriteLine(maxpoint);
        }

        private static void Exercise1_3()
        {
            var counts = Library.Books
                                .GroupBy(b => b.PublishedYear)
                                .OrderBy(b => b.Key);

            foreach (var count in counts)
            {
                Console.WriteLine($"{count.Key}年:{count.Count()}冊");
            }
        }

        private static void Exercise1_4()
        {
        }

        private static void Exercise1_5()
        {
        }

        private static void Exercise1_6()
        {
        }

        private static void Exercise1_7()
        {
        }

        private static void Exercise1_8()
        {
        }
    }
}
