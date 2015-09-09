namespace RayTracer
{
    class Ray
    {
        public Ray(Position position, Vector direction){
            this.origin = position;
            this.direction = direction;
        }
        public Position origin { get; set; }
        public Vector direction { get; set; }
        public override string ToString()
        {
            return origin.ToString() + " " + direction.ToString();
        }
    }
}