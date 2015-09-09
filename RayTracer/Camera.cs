using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracer
{
    class Camera
    {
        public Position position { get; set; }
        public Position lookAt { get; set; }
        public Vector direction { get; set; }
        public Vector right { get; set; }
        public Vector down { get; set; }

        public Camera(Position position, Position lookAt)
        {
            this.position = position;
            this.lookAt = lookAt;

            //determine camera Coord System

            Vector diff = new Vector(position.x - lookAt.x, position.y - lookAt.y, position.z - lookAt.z);
            this.direction = (-diff).normalize();
            this.right = new Vector(0, 1, 0).cross(direction).normalize();
            this.down = right.cross(direction);
        }

        public Camera() : this(new Position(3,1.5,-4), new Position(0,0,0))
        {
        }
    }
}
