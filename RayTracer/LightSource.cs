namespace RayTracer
{
    class LightSource
    {
        public LightSource(Position pos, Color color)
        {
            this.color = color;
            this.origin = pos;
        }
        public Color color { get; set; }
        public Position origin { get; set; }
        public override string ToString()
        {
            return "Light Source: " + origin;
        }
    }
}