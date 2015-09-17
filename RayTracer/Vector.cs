using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracer
{
    class Vector
    {
        //constructors
        public Vector(Position a, Position b)
        {
            this.x = a.x - b.x;
            this.y = a.y - b.y;
            this.z = a.z - b.z;
        }

        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        //variables
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }

        //overload operators
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }
        public static Vector operator -(Vector v)
        {
            return new Vector(-v.x, -v.y, -v.z);
        }
        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        }
        public static Vector operator *(Vector v, double s)
        {
            return new Vector(v.x * s, v.y * s, v.z * s);
        }
        public static Vector operator *(double s, Vector v)
        {
            return v * s;
        }
        public static Vector operator -(Vector v, Position p)
        {
            return new Vector(v.x - p.x, v.y - p.y, v.z - p.z);
        }
        public static Vector operator -(Position p, Vector v)
        {
            return new Vector(p.x-v.x, p.y-v.y, p.z-v.z);
        }
        //functions
        public double magnitude()
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
        }
        public Vector normalize()
        {
            double mag = magnitude();
            return new Vector(x/mag, y/mag, z/mag);
        }

        public Vector cross(Vector v)
        {
            return new Vector(this.y * v.z - this.z * v.y, -(this.x * v.z - this.z * v.x), this.x * v.y - this.y * v.x);
        }
        public double dot(Vector v)
        {
            return this.x * v.x + this.y * v.y + this.z * v.z;
        }
        public override string ToString()
        {
            return "(" + this.x + "," + this.y + "," + this.z + ")" + " ||" + magnitude() + "||";
        }
    }
}
