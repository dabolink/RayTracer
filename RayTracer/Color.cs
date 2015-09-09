using System;

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

        public Color(int v1, int v2, int v3)
        {
            this.r = v1;
            this.g = v2;
            this.b = v3;
            this.s = 0;
        }

        public int r { get; set; }
        public int g { get; set; }
        public int b { get; set; }
        public int s { get; set; }
        public static Color operator*(Color c, double d)
        {
            return new Color((int)(c.r / d), (int)(c.g / d), (int)(c.b / d));
        }
        public static Color operator +(Color c1, Color c2)
        {
            return new Color(c1.r + c2.r, c1.g + c2.g, c1.b + c2.b);
        }

        public Color clip()
        {
            if(r > 255)
            {
                r = 255;
            }
            if(g > 255)
            {
                g = 255;
            }
            if (b > 255)
            {
                b = 255;
            }
            return new Color(r,g,b);
        }
    }
}