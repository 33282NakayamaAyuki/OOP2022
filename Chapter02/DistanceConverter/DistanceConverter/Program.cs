﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    public class Program {
        //コマンドライン引数
        static void Main(string[] args)
        {
            if (args.Length >= 1 && args[0] == "-tom")
            {
                //フィートからメートルへの対応表を出力
                PrintFeetToMeterList(1, 10);
            }
            else
            {
                //メートルからフィートへの対応表を出力
                PrintMeterToFeetList(1, 10);

            }
        }
        //static FeetConverter feetconverter = new FeetConverter();

        //フィートからメートルへの対応表を出力
        private static void PrintMeterToFeetList(int start, int stop)
        {
            FeetConverter feetconverter = new FeetConverter();
            for (int meter = start; meter <= stop; meter++)
            {
                double feet = feetconverter.FromMeter(meter);
                Console.WriteLine("{0} ft = {1:0.0000} m", feet, meter);
            }
        }
//フィートからメートルへの対応表を出力
        private static void PrintFeetToMeterList(int start ,int stop)
        {
            FeetConverter feetconverter = new FeetConverter();
            for (int feet = start; feet <= stop; feet++)
            {
                double meter = feetconverter.ToMeter(feet);
                Console.WriteLine("{0} ft = {1:0.0000} m", feet, meter);
            }
        }
    }
}
