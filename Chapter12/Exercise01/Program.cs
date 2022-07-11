using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Exercise01 {
    [XmlRoot("employee")]
    public class Employee {
        [XmlElement(ElementName = "id")]
        public int Id { get; set; }
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "hireDate")]
        public DateTime HireDate { get; set; }
        
        public override string ToString()
        {
            return string.Format("[Id={0}, Name={1}, HireDate={2}]",
                                  Id, Name, HireDate);
        }
    }

    [DataContract(Name = "employee")]
    public class Employee2 {
        public int Id { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "hiredate")]
        public DateTime HireDate { get; set; }
        public override string ToString()
        {
            return string.Format("[Id={0}, Name={1}, HireDate={2}]",
                                  Id, Name, HireDate);
        }
    }
    class Program {
        static void Main(string[] args)
        {

            Exercise1_1("employee.xml");

            // これは確認用
            //Console.WriteLine(File.ReadAllText("employee.xml"));
            Console.WriteLine();

            Exercise1_2("employees.xml");
            Exercise1_3("employees.xml");
            Console.WriteLine();

            Exercise1_4("employees.json");

            // これは確認用
            Console.WriteLine(File.ReadAllText("employees.json"));
        }

        private static void Exercise1_1(string outfile)
        {
            var emp = new Employee
            {
                Id = 123,
                Name = "出井　秀行",
                HireDate = new DateTime(2001, 5, 10)
            };
            var settings = new XmlWriterSettings//見やすくしてくれる
            {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = "  ",
            };
            //シリアル化
            using (var writer = XmlWriter.Create(outfile,settings))
            {
                var serializer = new XmlSerializer(emp.GetType()); //p185
                serializer.Serialize(writer, emp);
            }

            //逆シリアル化
            using (var reader = XmlReader.Create("employee.xml"))
            {
                var serializer = new XmlSerializer(typeof(Employee)); //p185
                var employee = serializer.Deserialize(reader) as Employee;//as Novel キャストしている
                Console.WriteLine(employee);
            }
        }

        private static void Exercise1_2(string outfile)
        {
            //複数シリアル化
            var employees = new Employee[] {
            new Employee
            {
                Id = 123,
                Name = "出井　秀行",
                HireDate = new DateTime(2001, 5, 10)
            },
            new Employee
            {
                Id = 124,
                Name = "きんに君",
                HireDate = new DateTime(1995, 8, 20)
            },
        };
            var settings = new XmlWriterSettings//見やすくしてくれる
            {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = "  ",
            };
            using (var writer = XmlWriter.Create(outfile, settings))//settingsなしでもOK
            {
                var serializer = new DataContractSerializer(employees.GetType()); //p185
                serializer.WriteObject(writer, employees);
            }
            Display("employees.xml");
        }

        private static void Exercise1_3(string outfile)
        {
            using (var reader = XmlReader.Create(outfile))
            {
                var serializer = new DataContractSerializer(typeof(Employee[])); //p185
                var employees = serializer.ReadObject(reader) as Employee[];//as Novel キャストしている

                foreach (var employee in employees)
                {
                    Console.WriteLine(employee);
                }
            }
        }

        private static void Exercise1_4(string outfile)
        {
            var emps = new Employee2[] {
                new Employee2 {
                    Id = 123,
                    Name = "出井 秀行",
                    HireDate = new DateTime(2001, 5, 10)
                },
                new Employee2 {
                    Id = 139,
                    Name = "大橋 孝仁",
                    HireDate = new DateTime(2004, 12, 1)
                },
            };
            using (var stream = new FileStream(outfile, FileMode.Create, FileAccess.Write)) {
                var serializer = new DataContractJsonSerializer(emps.GetType(),new DataContractJsonSerializerSettings
                {
                    DateTimeFormat = new DateTimeFormat("yyyy-MM-dd")
                });
                serializer.WriteObject(stream, emps);
            }
        }
        //XMLファイルの中身表示用
        private static void Display(string filename)
        {
            var lines = File.ReadLines(filename);
            foreach (var line in lines)
                Console.WriteLine(line);

        }
    }
}
