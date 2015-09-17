namespace RayTracer
{
    class Position
    {
        public Position(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }
        public override string ToString()
        {
            return "(" + x + "," + y + "," + z + ")"; 
        }
        public static Position operator+(Position p, Vector v)
        {
            return new Position(v.x + p.x, v.y + p.y, v.z + p.z);
        }
    }
}