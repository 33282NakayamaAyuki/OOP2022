using SampleEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFramework {
    class Program {
        static void Main(string[] args)
        {
            //AddAuthors();
            //AddBooks();

            //Exercise_02();
            //Console.WriteLine();
            //Exercise_03();
            //Console.WriteLine();
            //Exercise_04();
            //Console.WriteLine();
            var authors = Exercise_0501();
            foreach (var author in authors)
            {
                Console.WriteLine($"{author.Name} {author.Birthday.ToString("yyyy/MM")}");
                var books = Exercise_0502(author.Name);
                foreach (var book in books)
                {
                    Console.WriteLine($"  {book.Title} {book.PublishedYear}");

                }
                Console.WriteLine();
            }

        }

        public static void Exercise_02() {
            
            var books = GetAllBooks();
            foreach (var book in books)
            {
                Console.WriteLine("タイトル:{0} 発行年:{1} 著者:{2}", book.Title, book.PublishedYear ,book.Author.Name);

            }
        }

        public static void Exercise_03() {
            using (var db = new BooksDbContext())
            {
                var books = db.Books
                            .Where(b => b.Title.Length == db.Books.Max(c => c.Title.Length));
                foreach (var book in books)
                {
                    Console.WriteLine(book.Title);
                }

            }
        }
        
        public static void Exercise_04()
        {
            using (var db = new BooksDbContext())
            {
                var books = db.Books.OrderBy(b => b.PublishedYear).Take(3);
                foreach (var book in books)
                {
                    Console.WriteLine(book.Title);
                }

            }
        }

        public static IEnumerable<Author> Exercise_0501()
        {
            using (var db = new BooksDbContext())
            {
                return db.Authors.OrderByDescending(a => a.Birthday).ToList();
            }
        }
        public static IEnumerable<Book> Exercise_0502(string name)
        {
            using (var db = new BooksDbContext())
            {
                return db.Books.Where(b => b.Author.Name == name).ToList();
            }
        }


    // List 13-9
    private static void AddAuthors()
        {
            using (var db = new BooksDbContext())
            {
                var author1 = new Author
                {
                    Birthday = new DateTime(1878, 12, 7),
                    Gender = "F",
                    Name = "与謝野晶子"
                };
                db.Authors.Add(author1);
                var author2 = new Author
                {
                    Birthday = new DateTime(1896, 8, 27),
                    Gender = "M",
                    Name = "宮沢賢治"
                };
                db.Authors.Add(author2);
                var author3 = new Author
                {
                    Birthday = new DateTime(1888, 12, 26),
                    Gender = "M",
                    Name = "菊池寛"
                };
                db.Authors.Add(author3);
                var author4 = new Author
                {
                    Birthday = new DateTime(1899, 6, 14),
                    Gender = "M",
                    Name = "川端康成"
                };
                db.Authors.Add(author4);
                var author5 = new Author
                {
                    Birthday = new DateTime(1909, 6, 19),
                    Gender = "M",
                    Name = "太宰治"
                };
                db.Authors.Add(author5);
                var author6 = new Author
                {
                    Birthday = new DateTime(1867, 1, 5),
                    Gender = "M",
                    Name = "夏目漱石"
                };
                db.Authors.Add(author6);
                db.SaveChanges();
            }
        }

        // List 13-10
        private static void AddBooks()
        {
            using (var db = new BooksDbContext())
            {
                var author1 = db.Authors.Single(a => a.Name == "与謝野晶子");
                var author2 = db.Authors.Single(a => a.Name == "宮沢賢治");
                var author3 = db.Authors.Single(a => a.Name == "夏目漱石");
                var author4 = db.Authors.Single(a => a.Name == "川端康成");
                var author5 = db.Authors.Single(a => a.Name == "菊池寛");

                var book1 = new Book
                {
                    Title = "みだれ髪",
                    PublishedYear = 2000,
                    Author = author1,
                };
                db.Books.Add(book1);

                var book2 = new Book
                {
                    Title = "銀河鉄道の夜",
                    PublishedYear = 1989,
                    Author = author2,
                };
                db.Books.Add(book2);

                var book3 = new Book
                {
                    Title = "こころ",
                    PublishedYear = 1991,
                    Author = author3,
                };
                db.Books.Add(book3);

                var book4 = new Book
                {
                    Title = "伊豆の踊子",
                    PublishedYear = 2003,
                    Author = author4,
                };
                db.Books.Add(book4);

                var book5 = new Book
                {
                    Title = "真珠夫人",
                    PublishedYear = 2002,
                    Author = author5,
                };
                db.Books.Add(book5);
                var book6 = new Book
                {
                    Title = "注文の多い料理店",
                    PublishedYear = 2000,
                    Author = author2,
                };
                db.Books.Add(book6);
                db.SaveChanges();
            }
        }

        static void InsertBooks()
        {
            using (var db = new BooksDbContext())
            {
                var book1 = new Book
                {
                    Title = "坊ちゃん",
                    PublishedYear = 2003,
                    Author = new Author
                    {
                        Birthday = new DateTime(1867, 2, 9),
                        Gender = "M",
                        Name = "夏目漱石",
                    }
                };

                db.Books.Add(book1);

                var book2 = new Book
                {
                    Title = "人間失格",
                    PublishedYear = 1990,
                    Author = new Author
                    {
                        Birthday = new DateTime(1909, 6, 19),
                        Gender = "M",
                        Name = "太宰治",
                    }
                };

                db.Books.Add(book2);
                db.SaveChanges();
            }
        }

        static IEnumerable<Book> GetAllBooks() {
            using (var db = new BooksDbContext()) {
                return db.Books.Include(nameof(Author)).ToList();
            }
        }

        static IEnumerable<Book> GetBooks()
        {
            using (var db = new BooksDbContext())
            {
                return db.Books
                    .Where(book => book.Title.Length == db.Books.Max(b =>b.Title.Length))
                    ;
            }
        }
    }
}
