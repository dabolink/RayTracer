using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayTracer
{
    class Object
    {
        public Vector normal { get; set; }
        public Color color { get; set; }

        public virtual Vector getNormalAt()
        {
            return normal;
        }
        public virtual double find_intersection(Ray ray)
        {
            Console.WriteLine("This shouldnt be here");
            return 0;
        }
    }
}
