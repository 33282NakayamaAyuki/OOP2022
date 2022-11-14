using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args)
        {
            OpenReadSample();
        }
        private static int RunAndWaitNotepad()
        {
            var path = @"%SystemRoot%\system32\notepad.exe";
            var fullpath = Environment.ExpandEnvironmentVariables(path);
            using (var process = Process.Start(fullpath))
            {
                if (process.WaitForExit(10000))
                    return process.ExitCode;
                throw new TimeoutException();
            }
        }

        public static void OpenReadSample()
        {
            var wc = new WebClient();
            using (var stream = wc.OpenRead(@"http://gihyo.jp/book/list"))
            using (var sr = new StreamReader(stream, Encoding.UTF8))
            {
                string html = sr.ReadToEnd();
                // 最初の2000文字だけ出力
                Console.WriteLine(html.Substring(0, 2000));
            }
        }
    }

}
