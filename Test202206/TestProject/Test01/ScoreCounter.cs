using System;
using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath)
        {

            _score = ReadScore(filePath);//_scoreにファイルを読み込む


        }


        //メソッドの概要： 点数のデータを読み込み、Studentオブジェクトのリストを返す
        private static IEnumerable<Student> ReadScore(string filePath)
        {

            List<Student> scores = new List<Student>();
            String[] lines = File.ReadAllLines(filePath);
            foreach (String line in lines)
            {
                String[] items = line.Split(',');
                Student student = new Student
                {
                    Name = items[0],
                    Subject = items[1],
                    score = int.Parse(items[2])
                };
                scores.Add(student);
            }

            return scores;

        }

        //メソッドの概要： 科目ごとに点数を足していく（科目ごとの合計を求めている）
        public IDictionary<string, int> GetPerStudentScore()
        {

            var dict = new Dictionary<string, int>();
            foreach (var scores in _score)
            {
                if (dict.ContainsKey(scores.Subject))
                    dict[scores.Subject] += scores.score;
                else
                    dict[scores.Subject] = scores.score;
            }

            return dict;

        }
    }
}
