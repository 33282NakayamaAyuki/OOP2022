﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    public class FeetConverter {

        //フィートからメートルを求める
        public double FromMeter(double Meter)
        {
            return Meter / 0.3048;
        }

        //メートルからフィートを求める
        public double ToMeter(double feet) {
            return feet / 0.3048;
        }
    }
}
