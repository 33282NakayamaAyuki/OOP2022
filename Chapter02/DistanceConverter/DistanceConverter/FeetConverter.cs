using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    public static　class FeetConverter {
        private const double ratio = 0.3048; // 定数ratioを定義　const(勝手にstaticになる) = final 、publicにするとダメ

        //public static readonly double ratio = 0.3048;//外部からもアクセスさせたい場合
        //フィートからメートルを求める(静的メソッド)
        public static double ToMeter(double feet)
        {
            return feet * ratio;
        }

        //メートルからフィートを求める(静的メソッド)
        public static double FromMeter(double Meter) {
            return Meter / ratio;
        }
    }
}
