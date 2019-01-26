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
        private int angleRange;
        private Random rand;

        public Sensor(V3 pos, V3 dir, int jit, int angleRange, Random rand) {
            Position = pos;
            Direction = dir;
            Jitter = jit;
            AngleRange = angleRange;
            this.rand = rand;
        }

        public double Poll(Plane[] obstacles) {
            double shortestDistance = MAX_RANGE + ((rand.NextDouble() * Jitter * 2) - Jitter);

            // Find the intersection distance (if it exists) with all the planes and take the shortest
            for (int i = 0; i < obstacles.Length; i++) {
                double distance = obstacles[i].intersects(this);
                if (distance < shortestDistance) {
                    // Add some jitter to the actual distance to simulate real sensor
                    shortestDistance = distance + ((rand.NextDouble() * Jitter * 2) - Jitter);
                }
            }

            return shortestDistance;
        }

        public V3 Position { get => position; set => position = value; }

        public V3 Direction { get => direction; set => direction = value; }

        public int Jitter { get => jitter; set => jitter = value; }

        public int AngleRange { get => angleRange; set => angleRange = value; }
    }
}
