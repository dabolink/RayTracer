using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace RayTracer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Daniel Bolink's Ray Tracer");
            //Read File
            //String filename = Console.ReadLine();
            //if (!filename.EndsWith(".txt")){
            //    filename += ".txt";
            //}
            //Console.WriteLine(filename);
            //try {
            //    string[] lines = System.IO.File.ReadAllLines(filename);
            //    foreach (string line in lines)
            //    {
            //        Console.WriteLine(line);
            //    }
            //}
            //catch(System.IO.FileNotFoundException)
            //{
            //    Console.WriteLine("File Not Found");
            //}

            //image size
            int width = 1000;
            int height = 1000;
            // Create Camera
            Camera c = new Camera(new Position(0, 0, -5), new Position(0,0,0));

            //create colors
            Color BGColor = new Color(255, 255, 255, 0);
            Color BLACK = new Color(0, 0, 0);
            Color WHITE = new Color(255, 255, 255);
            //create Objects in frame

            //red plane at below 10 units
            Object p = new Plane(new Vector(0,1,0), -1, new Color(255,0,0,0));
            //blue sphere 10 units ahead radis 0.5
            Object s = new Sphere(0.5, new Position(0, 0, 0), new Color(0, 125, 125, 0));

            //add Objects to list
            LinkedList<Object> objects = new LinkedList<Object>();
            objects.AddLast(s);
            objects.AddLast(p);

            //add Light Sources
            LightSource light = new LightSource(new Position(5, -5, 5), WHITE);

            //add lightsources to linked list
            LinkedList<LightSource> lightsources = new LinkedList<LightSource>();
            lightsources.AddLast(light);

            // Create Pixels
            Color[,] pixels = new Color[width, height];
            
            //ray tracing algorithm
            for(int x = 0; x < width; x++)
            {
                for (int y = 0; y<height; y++)
                {
                    double xamnt = (x + 0.5) / width;
                    double yamnt = ((height - y) + 0.5) / height;

                    Vector ray_direction = (c.direction + (c.right * (xamnt-0.5) + (c.down * (yamnt - 0.5)))).normalize();

                    Ray ray = new Ray(c.position, ray_direction);
                    
                    LinkedList<ObjectPair> intersection_objects = new LinkedList<ObjectPair>();
                    foreach(Object o in objects)
                    {
                        double val = o.find_intersection(ray);
                        if (val > 0)
                        {
                            intersection_objects.AddLast(new ObjectPair(o, val));
                        }
                        //Console.WriteLine(val);
                    }
                    //Console.WriteLine(intersection_objects.Count);
                    if(intersection_objects.Count == 0)
                    {
                        pixels[x, y] = BGColor;
                    }
                    else if(intersection_objects.Count == 1)
                    {
                        if(intersection_objects.First().val > 0)
                        {
                            pixels[x, y] = intersection_objects.First().obj.color;
                        }
                        else
                        {
                            pixels[x, y] = BGColor;
                        }
                    }
                    else
                    {
                        ObjectPair winner = new ObjectPair(null, -1);
                        foreach (ObjectPair o in intersection_objects)
                        {
                            if (winner.val == -1)
                            {
                                winner = o;
                            }
                            else if(winner.val > o.val && o.val >= 0)
                            {
                                winner = o;
                            }
                        }
                        if(winner.val > 0)
                        {
                            Color final_color = winner.obj.color;
                            Position intersection_point = ray.origin + (ray.direction * (winner.val*0.999));
                            foreach (LightSource l in lightsources)
                            {
                                Boolean shadowed = false;
                                Ray shadow_ray = new Ray(intersection_point, new Vector(l.origin, intersection_point).normalize());
                                foreach(Object o in objects)
                                {
                                    double obj_intersection = o.find_intersection(shadow_ray);
                                    if(!(obj_intersection == -1))
                                    {
                                        shadowed = true;
                                    }
                                }
                                if (shadowed)
                                {
                                    final_color += (l.color * (1 / lightsources.Count));
                                }
                            }
                            pixels[x, y] = final_color.clip();
                        }
                        else
                        {
                            pixels[x, y] = BGColor;
                        }
                    }
                }
            }

            //create image
            CreateImg(pixels);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        private static void CreateImg(Color[,] pixels)
        {
            int width = pixels.GetLength(0);
            int height = pixels.GetLength(1);
            Console.WriteLine(width + "," + height);
            Bitmap bmp = new Bitmap(width, height);
            for ( int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                 
                    bmp.SetPixel(i, j, System.Drawing.Color.FromArgb(pixels[i, j].r, pixels[i, j].g, pixels[i, j].b));
                }
            }
            bmp.Save("raytracer.png", System.Drawing.Imaging.ImageFormat.Png);
            bmp.Dispose();
        }
    }
}
