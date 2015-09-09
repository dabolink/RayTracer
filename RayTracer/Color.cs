namespace RayTracer
{
    public class Color
    {

        public Color(int red, int green, int blue, int special)
        {
            r = red;
            g = green;
            b = blue;
            s = special;
        }

        public int r { get; set; }
        public int g { get; set; }
        public int b { get; set; }
        public int s { get; set; }
    }
}