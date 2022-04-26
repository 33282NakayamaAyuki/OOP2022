﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    public static　class FeetConverter {

        //フィートからメートルを求める(静的メソッド)
        public static double FromMeter(double Meter)
        {
            return Meter / 0.3048;
        }

        //メートルからフィートを求める(静的メソッド)
        public static double ToMeter(double feet) {
            return feet / 0.3048;
        }
    }
}
