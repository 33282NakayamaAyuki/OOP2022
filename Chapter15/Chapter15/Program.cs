using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15 {
    class Program {
        static void Main(string[] args)
        {

            Console.WriteLine("出力したい西暦を入力(終了：-1)：");
            //yearsをリスト化
            var years = new List<int>();
            while (true)
            {
                if (years.Contains(-1))
                {
                    break;
                } else {
                    years.Add(int.Parse(Console.ReadLine()));
                }
            }

#if 先生の
            //int year;
            //Console.WriteLine("出力したい西暦を入力(終了：-1)：");
            //year = int.Parse(Console.ReadLine());
            //while (year != -1) {
            //    years.Add(year);
            //    year = int.Parse(Console.ReadLine());
            //}
#endif


            //1.(昇順)/2.(降順)　変換機能
            Console.Write("{昇順:1,降順:2} ->");
            var number = Console.ReadLine();
            var books = Library.Books
                            .Where(b => years.Contains(b.PublishedYear));

            if (int.Parse(number) == 1)
            {
                foreach (var book in books.OrderBy(c => c.PublishedYear))
                {
                    Console.WriteLine(book);
                }
            }
            if (int.Parse(number) == 2)
            {      
                foreach (var book in books.OrderByDescending(c => c.PublishedYear))
                {
                    Console.WriteLine(book);
                }
            }

            Console.WriteLine();

            var groups = Library.Books
                                .Where(b => years.Contains(b.PublishedYear))
                                .GroupBy(b => b.PublishedYear)
                                .OrderBy(g => g.Key );

            foreach (var g in groups)
            {
                Console.WriteLine($"{g.Key}年");
                foreach (var book in g)
                {
                    var category = Library.Categories.Where(b => b.Id == book.CategoryId).First();
                    Console.Write($"タイトル:{book.Title},価格:{book.Price},カテゴリ:{category.Name}");
                }
            }
        }
    }
}
