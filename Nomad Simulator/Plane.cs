using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Nomad_Simulator {
    class Plane {

        private V3 topLeftPoint;
        private V3 topRightPoint;
        private V3 bottomLeftPoint;
        private V3 bottonRightPoint;
        private V3 normal;

        public Plane(V3 tlp, V3 trp, V3 blp, V3 brp) {
            topLeftPoint = tlp;
            topRightPoint = trp;
            bottomLeftPoint = blp;
            bottonRightPoint = brp;

            normal = CrossProduct(SubtractVector(trp, tlp), SubtractVector(blp, tlp));
        }

        public double intersects(Sensor s) {
            if (DotProduct(normal, s.Direction) == 0) {
                return float.MaxValue;
            }

            double t = (DotProduct(normal, topLeftPoint) - DotProduct(normal, s.Position)) / DotProduct(normal, s.Direction);
            double dist = VectorLength(ScaleVector(s.Direction, (float) t));
            V3 intersect = AddVector(s.Position, ScaleVector(s.Direction, (float)t));

            if (intersect.X >= TopLeftPoint.X && intersect.X <= BottonRightPoint.X &&
                intersect.Y >= TopLeftPoint.Y && intersect.Y <= BottonRightPoint.Y &&
                intersect.Z >= TopLeftPoint.Z && intersect.Z <= BottonRightPoint.Z) {
                return dist;
            }

            return double.MaxValue;
        }

        private double DotProduct(V3 a, V3 b) {
            return a.X * b.X + a.Y * b.Y + a.Z * b.Z;
        }

        private V3 CrossProduct(V3 a, V3 b) {
            return new V3(  a.Y * b.Z - a.Z * b.Y, 
                            a.Z * b.X - a.X * b.Z,
                            a.X * b.Y - a.Y * b.X);
        }

        private V3 ScaleVector(V3 a, float scale) {
            return new V3(a.X * scale, a.Y * scale, a.Z * scale);
        }

        private double VectorLength(V3 a) {
            return Math.Sqrt(a.X * a.X + a.Y * a.Y + a.Z * a.Z);
        }

        private V3 AddVector(V3 a, V3 b) {
            return new V3(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        private V3 SubtractVector(V3 a, V3 b) {
            return new V3(a.X - b.X, a.Y - b.Y, a.Z - b.Z);
        }

        public void Move(V3 move) {
            TopLeftPoint = AddVector(TopLeftPoint, move);
            TopRightPoint = AddVector(TopRightPoint, move);
            BottonRightPoint = AddVector(BottonRightPoint, move);
            BottomLeftPoint = AddVector(BottomLeftPoint, move);
        }

        public V3 TopLeftPoint { get => topLeftPoint; set => topLeftPoint = value; }

        public V3 TopRightPoint { get => topRightPoint; set => topRightPoint = value; }

        public V3 BottomLeftPoint { get => bottomLeftPoint; set => bottomLeftPoint = value; }

        public V3 BottonRightPoint { get => bottonRightPoint; set => bottonRightPoint = value; }

        public V3 Normal { get => normal; set => normal = value; }

    }
}
