using System;

namespace RayTracer
{
    internal class Plane : Object
    {
        public Plane(Vector normal, double distance, Color color)
        {
            this.distance = distance;
            this.normal = normal;
            this.color = color;
        }
        public override Vector getNormalAt()
        {
            return normal;
        }
        public override double find_intersection(Ray ray)
        {
            double a = ray.direction.dot(normal);

            if (a == 0)
            {
                return -1;
            }
            double b = normal.dot(ray.origin - (normal * distance));
            double n = -1 * b / a;
            return n;
        }
        public double distance { get; set; }
    }
}