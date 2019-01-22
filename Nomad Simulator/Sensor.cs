using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Nomad_Simulator {
    class Sensor {

        private static readonly float MAX_RANGE = 500;

        private V3 position;
        private V3 direction;
        private int jitter;
        private Random rand;

        public Sensor(V3 pos, V3 dir, int jit) {
            Position = pos;
            Direction = dir;
            Jitter = jit;
            rand = new Random();
        }

        public double Poll(Plane[] obstacles) {
            double shortestDistance = MAX_RANGE;

            for (int i = 0; i < obstacles.Length; i++) {
                double distance = obstacles[i].intersects(this);
                if (distance < shortestDistance) {
                    shortestDistance = distance + ((rand.NextDouble() * Jitter * 2) - Jitter);
                }
            }

            return shortestDistance;
        }

        public V3 Position { get => position; set => position = value; }

        public V3 Direction { get => direction; set => direction = value; }

        public int Jitter { get => jitter; set => jitter = value; }
    }
}
