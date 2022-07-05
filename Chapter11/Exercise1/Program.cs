using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = "sample.xml";
            Exercise1_1(file);
            Console.WriteLine();
            Exercise1_2(file);
            Console.WriteLine();
            Exercise1_3(file);
            Console.WriteLine();

            var newfile = "sports.xml";
            Exercise1_4(file, newfile);

        }

        private static void Exercise1_1(string file)
        {
            //匿名クラス　P284
            var xdoc = XDocument.Load(file);
            var sports = xdoc.Root.Elements()
                             .Select(x => new {
                                 Name = x.Element("name").Value,
                                 Teammembers = x.Element("teammembers").Value
                             });
            foreach (var sport in sports)
            {
                Console.WriteLine("{0} {1}", sport.Name, sport.Teammembers);
            }

        }

        private static void Exercise1_2(string file)
        {
            //匿名クラス（最初にプレーされた年の若い順と合わせて競技名を表示）
            var xdoc = XDocument.Load(file);
            var sports = xdoc.Root.Elements().Select(x => new {
                        Kanji = x.Element("name").Attribute("kanji").Value,
                        Firstplayed = x.Element("firstplayed").Value
                }).OrderBy(x=>x.Firstplayed);
            foreach (var sport in sports)
            {
                Console.WriteLine("{0} {1}", sport.Kanji, sport.Firstplayed);
            }                         
        }

        private static void Exercise1_3(string file)
        {
            var xdoc = XDocument.Load(file);
            var sports = xdoc.Root.Elements()
                             .Select(x => new {
                                 Name = x.Element("name").Value,
                                 Teammembers = x.Element("teammembers").Value
                             })
                             .OrderByDescending(x=>int.Parse(x.Teammembers)).First();
                Console.WriteLine(sports.Name);
        }

        private static void Exercise1_4(string file, string newfile)
        {
            //要素の追加  P290

        }
    }
}
