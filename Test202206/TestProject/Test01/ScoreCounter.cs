using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {

            _score = ReadScore(filePath);


        }


        //メソッドの概要： 
        private static IEnumerable<Student> ReadScore(string filePath) {

            var dict = new Dictionary<string, int>();
            foreach (var students in _score)
            {
                if (dict.ContainsKey(students.Subject))
                    dict[students.Name] += students.score;
                else
                    dict[students.Name] = students.score;
            }


            return dict;






        }

        //メソッドの概要： 
        public IDictionary<string, int> GetPerStudentScore() {





            
        }
    }
}
