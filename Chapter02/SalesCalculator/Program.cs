﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator {
    class Program {
        static void Main(string[] args) {
            SalesCounter sales = new SalesCounter("sales.csv");
            IDictionary<string, int> amountPerStore = sales.GetPerStoreSales();
            foreach (KeyValuePair<String, int> obj in amountPerStore)
            {
                Console.WriteLine("{0} {1}", obj.Key, obj.Value);
            }

            int data;
            double num = 234.5;

            data = (int)num;//キャスト
        
        }
       
    }
}
