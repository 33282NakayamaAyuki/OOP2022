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
            Console.WriteLine(maxpoint);

#if　先生の
            var max = Library.Books.Max(b => b.Price);
            var book = Library.Books.Where(b => b.Price == max)
            Console.WriteLine(book);
#endif
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
            var sort = Library.Books
                              .OrderByDescending(b => b.PublishedYear)
                              .ThenByDescending(b => b.Price)
                              .Join(Library.Categories,
                                        book => book.CategoryId,
                                        category => category.Id,
                                        (book, category) => new
                                        {
                                            Title = book.Title,
                                            Category = category.Name,
                                            PublishedYear = book.PublishedYear,
                                            Price = book.Price
                                        }
                                   )
                              ;
            foreach (var book in sort)
            {
                Console.WriteLine($"{book.PublishedYear}年 {book.Price}円 {book.Title} ({book.Category})");
            }
        }

        private static void Exercise1_5()
        {
            var lists = Library.Books
                               .Where(b => b.PublishedYear == 2016)
                               .Join(Library.Categories,
                                        book => book.CategoryId,
                                        category => category.Id,
                                        (book, category) => new
                                        {
                                            Category = category.Name
                                        }
                                        )
                               .ToList()
                               .Distinct()
                              ;

            foreach (var list in lists)
            {
                Console.WriteLine($"{list.Category}");
            }


        }

        private static void Exercise1_6()
        {
            var orders = Library.Books
                                .GroupBy(b => b.CategoryId)
                                .Join(Library.Categories,
                                        book => book.Key,
                                        category => category.Id,
                                        (book, category) => new
                                        {
                                            Category = category.Name,
                                            Books = book,
                                        }
                                 )
                                .OrderBy(b=>b.Category)
                                ;


            foreach (var count in orders)
            {
                Console.WriteLine($"#{count.Category}");
                foreach (var a in count.Books)
                {
                    Console.WriteLine($" {a.Title}");
                }
            }
        }

        private static void Exercise1_7()
        {
            var selected = Library.Books
                              .Where(b => b.CategoryId == 1)
                              .GroupBy(b => b.PublishedYear)
                              .OrderBy(b => b.Key)
                             ;

            foreach (var select in selected)
            {
                Console.WriteLine($"#{select.Key}年");
                foreach (var s in select)
                {
                    Console.WriteLine($"  {s.Title}");
                }

            }
        }

        private static void Exercise1_8()
        {
            var counts = Library.Categories
                                .GroupJoin(Library.Books,
                                book => book.Id,
                                category => category.CategoryId,
                                        (category, book) => new
                                        {
                                            Category = category.Name
                                            ,
                                            Count = book.Count()
                                        }
                                )
                                .Where(b => b.Count >= 4)
                                ;

            foreach (var count in counts)
            {
                Console.WriteLine($"{count.Category}");
            }
            
        }
    }
}
