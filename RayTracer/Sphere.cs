using System;
namespace RayTracer
{
    internal class Sphere : Object
    {
        public Sphere(double radius, Position center, Color color)
        {
            this.radius = radius;
            this.color = color;
            this.center = center;
        }
        public double radius { get; set; }
        public Position center { get; set; }
        public override double find_intersection(Ray ray)
        {
            double b = (2 * (ray.origin.x - center.x) * ray.direction.x) + (2 * (ray.origin.y - center.y) * ray.direction.y) + (2 * (ray.origin.z - center.z) * ray.direction.z);
            double c = Math.Pow((ray.origin.x - center.x), 2) + Math.Pow((ray.origin.y - center.y), 2) + Math.Pow((ray.origin.z - center.z), 2) - Math.Pow(radius, 2);
            double discriminant = Math.Pow(b, 2) - 4 * c;
            if (discriminant > 0)
            {
                double root = ((-1 * b - Math.Sqrt(discriminant)) / 2);
                if (root > 0)
                {
                    return root;
                }
                else
                {
                    return ((-b + Math.Sqrt(discriminant)) / 2);
                }
            }
            else
            {
                return -1;
            }
        }
        public override Vector getNormalAt(Position point)
        {
            return new Vector(point, center);
        }
        public override string ToString()
        {
            return "Sphere: " + center + ", " + radius ;
        }
    }
}