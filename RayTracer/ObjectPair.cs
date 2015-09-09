namespace RayTracer
{
    internal class ObjectPair
    {
        public ObjectPair(Object obj, double val)
        {
            this.obj = obj;
            this.val = val;
        }

        public Object obj { get; set; }
        public double val { get; set; } 
    }
}