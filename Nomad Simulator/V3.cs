using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomad_Simulator {
    class V3 {

        private double X1;
        private double Y1;
        private double Z1;

        public V3(double x, double y, double z) {
            X = x;
            Y = y;
            Z = z;
        }

        public double X { get => X1; set => X1 = value; }
        public double Y { get => Y1; set => Y1 = value; }
        public double Z { get => Z1; set => Z1 = value; }

        public string ToString() {
            return "(" + X + "," + Y + "," + Z + ")";
        }
    }
}
