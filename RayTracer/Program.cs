using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.IO;

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
            Camera c = new Camera(new Position(0, 0, -10), new Position(0,0,0));
            
            //create colors
            Color BGColor = new Color(0, 0, 0);
            Color BLACK = new Color(0, 0, 0);
            Color WHITE = new Color(255, 255, 255);
            Color GREEN = new Color(0, 255, 0);
            Color YELLOW = new Color(255, 255, 0);
            Color ORANGE = new Color(255, 0, 255);
            Color RED = new Color(200, 0, 0);
            Color BLUE = new Color(0, 0, 255);
            //create Objects in frame

            //red plane at below 10 units
            Object p1 = new Plane(new Vector(0, 1, 0), -1, RED);
            //blue sphere 10 units ahead radis 0.5
            Object s1 = new Sphere(1, new Position(0, 0, 0), BLACK);
            Object s2 = new Sphere(1, new Position(2, 0, 0), ORANGE);

            //add Objects to list
            LinkedList<Object> objects = new LinkedList<Object>();
            objects.AddLast(s1);
            objects.AddLast(p1);
            objects.AddLast(s2);

            //add Light Sources
            LightSource l1 = new LightSource(new Position(20, 5, 10), WHITE);
            LightSource l2 = new LightSource(new Position(-20, 5, 10), BLUE);

            //add lightsources to linked list
            LinkedList<LightSource> lightsources = new LinkedList<LightSource>();
            lightsources.AddLast(l1);
            lightsources.AddLast(l2);

            //create lighting variables
            double ambient_light = 0.15;

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
                                Vector light_direction = new Vector(intersection_point, l.origin).normalize();
                                Ray shadow_ray = new Ray(intersection_point, light_direction);
                                foreach(Object o in objects)
                                {
                                    double obj_intersection = o.find_intersection(shadow_ray);
                                    if(obj_intersection > 0)
                                    {
                                        shadowed = true;
                                        break;
                                    }
                                }

                                if (!shadowed)
                                {

                                    Vector Winner_obj_normal = winner.obj.getNormalAt(intersection_point);
                                    double diffuse_coeffient = (shadow_ray.direction.dot(Winner_obj_normal));
                                    Vector reflection_direction = shadow_ray.direction - (2 * (shadow_ray.direction.dot(Winner_obj_normal)/Winner_obj_normal.magnitude()*Winner_obj_normal));
                                    Ray reflection = new Ray(intersection_point, reflection_direction);

                                    double specular_coefficient = reflection.direction.dot(ray.direction);
                                    final_color += l.color * 0.15;
                                    if(diffuse_coeffient > 0)
                                    {
                                        final_color += l.color * diffuse_coeffient * 0.15;
                                    }
                                    if(specular_coefficient > 0)
                                    {
                                        final_color += l.color * Math.Pow(specular_coefficient, 1000);
                                    }

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
            Process photoViewer = Process.Start("RayTracer.png");
            //prompt for exit
            //Console.WriteLine("Press any key to exit.");
            //Console.ReadKey();
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
                 
                    bmp.SetPixel(i, j, System.Drawing.Color.FromArgb((int)pixels[i, j].r, (int)pixels[i, j].g, (int)pixels[i, j].b));
                }
            }
            bmp.Save("raytracer.png", System.Drawing.Imaging.ImageFormat.Png);
            bmp.Dispose();
        }
    }
}
