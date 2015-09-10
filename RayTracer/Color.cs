using System;

namespace RayTracer
{
    public class Color
    {

        public Color(double red, double green, double blue, double special)
        {
            r = red;
            g = green;
            b = blue;
            s = special;
        }

        public Color(double v1, double v2, double v3)
        {
            this.r = v1;
            this.g = v2;
            this.b = v3;
            this.s = 0;
        }

        public double r { get; set; }
        public double g { get; set; }
        public double b { get; set; }
        public double s { get; set; }

        public static Color operator*(Color c, double d)
        {
            return new Color(c.r * d, c.g * d, c.b * d, c.s);
        }
        public static Color operator +(Color c1, Color c2)
        {
            return new Color(c1.r + c2.r, c1.g + c2.g, c1.b + c2.b, c1.s);
        }
        public static Color operator *(Color c1, Color c2)
        {
            return new Color((c1.r * c2.r), (c1.g + c2.g), (c1.b + c2.b), c1.s);
        }
        public Color Average(Color c2)
        {
            return new Color((this.r * c2.r) / 2, (this.g + c2.g) / 2, (this.b + c2.b) / 2, this.s);
        }

        public Color clip()
        {
            if(r > 255)
            {
                r = 255;
            }
            if (r < 0)
            {
                r = 0;
            }
            if(g > 255)
            {
                g = 255;
            }
            if (g < 0)
            {
                g = 0;
            }
            if (b > 255)
            {
                b = 255;
            }
            if (b < 0)
            {
                b = 0;
            }
            return new Color(r,g,b);
        }
    }
}