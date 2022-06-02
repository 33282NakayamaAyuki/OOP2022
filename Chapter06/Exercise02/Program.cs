using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args)
        {
            var books = new List<Book> {
                new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
                new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
                new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
                new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
                new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
                new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453 },
                new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
         };
            #region
            Exercise2_1(books);
            Console.WriteLine("-----");

            Exercise2_2(books);

            Console.WriteLine("-----");

            Exercise2_3(books);
            Console.WriteLine("-----");

            Exercise2_4(books);
            Console.WriteLine("-----");

            Exercise2_5(books);
            Console.WriteLine("-----");

            Exercise2_6(books);

            Console.WriteLine("-----");

            Exercise2_7(books);
            #endregion
        }

        class Book {
            public string Title { get; set; }
            public int Price { get; set; }
            public int Pages { get; set; }
        }

        private static void Exercise2_1(List<Book> books)
        {
            //foreach (var book in books.TakeWhile(book => book.Title.Contains("ワンダフル・C#ライフ")))
            //{
            //    Console.WriteLine("価格：" + book.Price);
            //    Console.WriteLine("ページ数：" + book.Pages);
            //}

            foreach (var book in books.FindAll(book => book.Title.Contains("ワンダフル・C#ライフ")))
            {
                Console.WriteLine("価格：" + book.Price);
                Console.WriteLine("ページ数：" + book.Pages);
            }
        }

        private static void Exercise2_2(List<Book> books)
        {
            var count = books.Count(book => book.Title.Contains("C#"));
            Console.WriteLine(count);
        }

        private static void Exercise2_3(List<Book> books)
        {
            var title = books.Where(book => book.Title.Contains("C#"));
            var avarage = title.Average(book => book.Pages);
            Console.WriteLine(avarage);

        }

        private static void Exercise2_4(List<Book> books)
        {
            var first = books.FirstOrDefault(book => book.Price >= 4000);
            Console.WriteLine(first.Title);
        }

        private static void Exercise2_5(List<Book> books)
        {
            var code = books.Where(book => book.Price < 4000).Max(book => book.Pages);
            Console.WriteLine(code);
        }

        private static void Exercise2_6(List<Book> books)
        {
            foreach (var code in books.Where(book => book.Pages >= 400).OrderByDescending(book => book.Price))
            {
                Console.WriteLine(code.Title);
            }
        }

        private static void Exercise2_7(List<Book> books)
        {
            foreach (var code in books.Where(book => book.Title.Contains("C#") && book.Pages <= 500))
            {
                Console.WriteLine(code.Title);
            }
        }
    }
}
