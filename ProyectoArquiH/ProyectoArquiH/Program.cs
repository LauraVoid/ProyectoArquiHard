using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace ProyectoArquiH
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = true;
            while (salir)
            {

            
            Console.WriteLine("Version (1,2,3)");
            String ver = Console.ReadLine();
            int version = int.Parse(ver);
            Console.WriteLine("size (64,160,512,1500)");
            String si = Console.ReadLine();
            int size = int.Parse(si);
            Console.WriteLine("depth (8,24,32)");
            String dep = Console.ReadLine();
            int depth = int.Parse(dep);

            String imagen648 = "./Imagenes/64/8.jpg";
            String imagen1608 = "./Imagenes/160/8.jpg";
            String imagen5128 = "./Imagenes/512/8.jpg";
            String imagen15008 = "./Imagenes/1500/8.jpg";

            String imagen6416 = "./Imagenes/64/24.jpg";
            String imagen16016 = "./Imagenes/160/24.jpg";
            String imagen51216 = "./Imagenes/512/24.jpg";
            String imagen150016 = "./Imagenes/1500/24.jpg";

            String imagen6432 = "./Imagenes/64/32.jpg";
            String imagen16032 = "./Imagenes/160/32.jpg";
            String imagen51232 = "./Imagenes/512/32.jpg";
            String imagen150032 = "./Imagenes/1500/32.jpg";
            switch (version)
            {
                case 1:
                    if (size == 64)
                    {
                        if (depth == 8)
                        {
                            version1(imagen648, depth, size);
                        }
                        if (depth == 24)
                        {
                            version1(imagen6416, depth, size);
                        }
                        if (depth == 32)
                        {
                            version1(imagen6432, depth, size);
                        }

                    }
                    if (size == 160)
                    {
                        if (depth == 8)
                        {
                            version1(imagen1608, depth, size);
                        }
                        if (depth == 24)
                        {
                            version1(imagen16016, depth, size);
                        }
                        if (depth == 32)
                        {
                            version1(imagen16016, depth, size);
                        }

                    }
                    if (size == 512)
                    {
                        if (depth == 8)
                        {
                            version1(imagen5128, depth, size);
                        }
                        if (depth == 24)
                        {
                            version1(imagen51216, depth, size);
                        }
                        if (depth == 32)
                        {
                            version1(imagen51232, depth, size);
                        }

                    }
                    if (size == 1500)
                    {
                        if (depth == 8)
                        {
                            version1(imagen15008, depth, size);
                        }
                        if (depth == 24)
                        {
                            version1(imagen150016, depth, size);
                        }
                        if (depth == 32)
                        {
                            version1(imagen150032, depth, size);
                        }

                    }
                    break;
                case 2:
                    if (size == 64)
                    {
                        if (depth == 8)
                        {
                            version2(imagen648, depth, size);
                        }
                        if (depth == 24)
                        {
                            version2(imagen6416, depth, size);
                        }
                        if (depth == 32)
                        {
                            version2(imagen6432, depth, size);
                        }

                    }
                    if (size == 160)
                    {
                        if (depth == 8)
                        {
                            version2(imagen1608, depth, size);
                        }
                        if (depth == 24)
                        {
                            version2(imagen16016, depth, size);
                        }
                        if (depth == 32)
                        {
                            version2(imagen16032, depth, size);
                        }

                    }
                    if (size == 512)
                    {
                        if (depth == 8)
                        {
                            version2(imagen5128, depth, size);
                        }
                        if (depth == 24)
                        {
                            version2(imagen51216, depth, size);
                        }
                        if (depth == 32)
                        {
                            version2(imagen51232, depth, size);
                        }

                    }
                    if (size == 1500)
                    {
                        if (depth == 8)
                        {
                            version2(imagen15008, depth, size);
                        }
                        if (depth == 24)
                        {
                            version2(imagen150016, depth, size);
                        }
                        if (depth == 32)
                        {
                            version2(imagen150032, depth, size);
                        }

                    }
                    break;

                case 3:
                    if (size == 64)
                    {
                        if (depth == 8)
                        {
                            version3(imagen648, depth, size);
                        }
                        if (depth == 24)
                        {
                            version3(imagen6416, depth, size);
                        }
                        if (depth == 32)
                        {
                            version3(imagen6432, depth, size);
                        }

                    }
                    if (size == 160)
                    {
                        if (depth == 8)
                        {
                            version3(imagen1608, depth, size);
                        }
                        if (depth == 24)
                        {
                            version3(imagen16016, depth, size);
                        }
                        if (depth == 32)
                        {
                            version3(imagen16032, depth, size);
                        }

                    }
                    if (size == 512)
                    {
                        if (depth == 8)
                        {
                            version3(imagen5128, depth, size);
                        }
                        if (depth == 24)
                        {
                            version3(imagen51216, depth, size);
                        }
                        if (depth == 32)
                        {
                            version3(imagen51232, depth, size);
                        }

                    }
                    if (size == 1500)
                    {
                        if (depth == 8)
                        {
                            version3(imagen15008, depth, size);
                        }
                        if (depth == 24)
                        {
                            version3(imagen150016, depth, size);
                        }
                        if (depth == 32)
                        {
                            version3(imagen150032, depth, size);
                        }

                    }
                    break;

                case 4:
                    if (size == 64)
                    {
                        if (depth == 8)
                        {
                            version4(imagen648, depth, size);
                        }
                        if (depth == 24)
                        {
                            version4(imagen6416, depth, size);
                        }
                        if (depth == 32)
                        {
                            version4(imagen6432, depth, size);
                        }

                    }
                    if (size == 160)
                    {
                        if (depth == 8)
                        {
                            version4(imagen1608, depth, size);
                        }
                        if (depth == 24)
                        {
                            version4(imagen16016, depth, size);
                        }
                        if (depth == 32)
                        {
                            version4(imagen16032, depth, size);
                        }

                    }
                    if (size == 512)
                    {
                        if (depth == 8)
                        {
                            version4(imagen5128, depth, size);
                        }
                        if (depth == 24)
                        {
                            version4(imagen51216, depth, size);
                        }
                        if (depth == 32)
                        {
                            version4(imagen51232, depth, size);
                        }

                    }
                    if (size == 1500)
                    {
                        if (depth == 8)
                        {
                            version4(imagen15008, depth, size);
                        }
                        if (depth == 24)
                        {
                            version4(imagen150016, depth, size);
                        }
                        if (depth == 32)
                        {
                            version4(imagen150032, depth, size);
                        }

                    }
                    break;

                case 5:
                    if (size == 64)
                    {
                        if (depth == 8)
                        {
                            version5(imagen648, depth, size);
                        }
                        if (depth == 24)
                        {
                            version5(imagen6416, depth, size);
                        }
                        if (depth == 32)
                        {
                            version5(imagen6432, depth, size);
                        }

                    }
                    if (size == 160)
                    {
                        if (depth == 8)
                        {
                            version5(imagen1608, depth, size);
                        }
                        if (depth == 24)
                        {
                            version5(imagen16016, depth, size);
                        }
                        if (depth == 32)
                        {
                            version5(imagen16032, depth, size);
                        }

                    }
                    if (size == 512)
                    {
                        if (depth == 8)
                        {
                            version5(imagen5128, depth, size);
                        }
                        if (depth == 24)
                        {
                            version5(imagen51216, depth, size);
                        }
                        if (depth == 32)
                        {
                            version5(imagen51232, depth, size);
                        }

                    }
                    if (size == 1500)
                    {
                        if (depth == 8)
                        {
                            version5(imagen15008, depth, size);
                        }
                        if (depth == 24)
                        {
                            version5(imagen150016, depth, size);
                        }
                        if (depth == 32)
                        {
                            version5(imagen150032, depth, size);
                        }

                    }
                    break;
              default:                         
                 salir = false;
                  break;
            }
            }
        }

        static void version1(String ubicacion, int depth, int size)
        {
            StreamWriter sw = new StreamWriter("./Txt/Tiempo1.txt");
            Console.WriteLine(ubicacion);
            Bitmap original = new Bitmap(ubicacion);
            original.Save("./img/Version1-0.png");
            Bitmap a = original;
            Color c;
            //Stopwatch
            long tiempo = 0;
            Stopwatch timeA = new Stopwatch();
            timeA.Restart();
            timeA.Start();
            for (int i = 0; i < a.Height - 1; i++)
            {
                for (int j = 0; j < a.Width - 1; j++)
                {
                    c = a.GetPixel(i, j);
                    c = Color.FromArgb(255, (255 - c.R), (255 - c.G), (255 - c.B));
                    a.SetPixel(i, j, c);
                }
            }
            timeA.Stop();

            tiempo = (long)(timeA.Elapsed.TotalMilliseconds * 1000000); //*1000000 ns; *1000 us
            Console.WriteLine("Tiempo " + tiempo);
            sw.WriteLine("Version 1; " + a.Height + "x" + a.Width + "; " + tiempo);
            sw.Close();

            a.Save("./inv/version1/" + depth + "-" + size + ".jpg", ImageFormat.Jpeg);
            original.Dispose();
            a.Dispose();
        }
        static void version2(String ubicacion, int depth, int size)
        {
            StreamWriter sw = new StreamWriter("./Txt/Tiempo2.txt");
            Bitmap original = new Bitmap(ubicacion);
            original.Save("./img/Version2-0.png");
            Bitmap a = original;
            Color c;

            long tiempo = 0;
            Stopwatch timeA = new Stopwatch();
            timeA.Restart();
            timeA.Start();
            for (int i = 0; i < a.Height - 1; i++)
            {
                for (int j = 0; j < a.Width - 1; j++)
                {
                    c = a.GetPixel(i, j);
                    c = Color.FromArgb(255, (255 - c.R), c.G, c.B);
                    a.SetPixel(i, j, c);
                }
            }

            for (int i = 0; i < a.Height - 1; i++)
            {
                for (int j = 0; j < a.Width - 1; j++)
                {
                    c = a.GetPixel(i, j);
                    c = Color.FromArgb(255, c.R, (255 - c.G), c.B);
                    a.SetPixel(i, j, c);
                }
            }

            for (int i = 0; i < a.Height - 1; i++)
            {
                for (int j = 0; j < a.Width - 1; j++)
                {
                    c = a.GetPixel(i, j);
                    c = Color.FromArgb(255, c.R, c.G, (255 - c.B));
                    a.SetPixel(i, j, c);
                }
            }
            timeA.Stop();

            tiempo = (long)(timeA.Elapsed.TotalMilliseconds * 1000000); //*1000000 ns; *1000 us
            Console.WriteLine("Tiempo " + tiempo);
            sw.WriteLine("Version 2; " + a.Height + "x" + a.Width + "; " + tiempo);
            sw.Close();
            a.Save("./inv/version2/" + depth + "-" + size + ".jpg", ImageFormat.Jpeg);
            original.Dispose();
            a.Dispose();
           
        }
        static void version3(String ubicacion, int depth, int size)
        {
            StreamWriter sw = new StreamWriter("./Txt/Tiempo3.txt");
            Bitmap original = new Bitmap(ubicacion);
            original.Save("./img/Version3-0.png");
            Bitmap a = original;
            Color c;

            long tiempo = 0;
            Stopwatch timeA = new Stopwatch();
            timeA.Restart();
            timeA.Start();
            for (int j = 0; j < a.Width - 1; j++)
            {
                for (int i = 0; i < a.Height - 1; i++)
                {
                    c = a.GetPixel(i, j);
                    c = Color.FromArgb(255, (255 - c.R), (255 - c.G), (255 - c.B));
                    a.SetPixel(i, j, c);
                }
            }
            timeA.Stop();

            tiempo = (long)(timeA.Elapsed.TotalMilliseconds * 1000000); //*1000000 ns; *1000 us
            Console.WriteLine("Tiempo " + tiempo);
            sw.WriteLine("Version 3; " + a.Height + "x" + a.Width + "; " + tiempo);
            sw.Close();
            a.Save("./inv/version3/" + depth + "-" + size + ".jpg", ImageFormat.Jpeg);
            original.Dispose();
            a.Dispose();
        }
        static void version4(String ubicacion, int depth, int size)
        {
            StreamWriter sw = new StreamWriter("./Txt/Tiempo4.txt");
            Bitmap original = new Bitmap(ubicacion);
            original.Save("./img/Version4-0.png");
            Bitmap a = original;
            Color c;

            long tiempo = 0;
            Stopwatch timeA = new Stopwatch();
            timeA.Restart();
            timeA.Start();
            for (int i = 0; i < a.Height - 1; i++)
            {
                for (int j = 0; j < a.Width - 1; j++)
                {
                    c = a.GetPixel(i, j);
                    c = Color.FromArgb(255, (255 - c.R), c.G, c.B);
                    a.SetPixel(i, j, c);
                }
            }

            for (int i = a.Height - 1; i > 0; i--)
            {
                for (int j = a.Width - 1; j > 0; j--)
                {
                    c = a.GetPixel(i, j);
                    c = Color.FromArgb(255, c.R, (255 - c.G), (255 - c.B));
                    a.SetPixel(i, j, c);
                }
            }
            timeA.Stop();

            tiempo = (long)(timeA.Elapsed.TotalMilliseconds * 1000000); //*1000000 ns; *1000 us
            Console.WriteLine("Tiempo " + tiempo);
            sw.WriteLine("Version 4; " + a.Height + "x" + a.Width + "; " + tiempo);
            sw.Close();
            a.Save("./inv/version4/" + depth +"-"+ size+".jpg", ImageFormat.Jpeg);
            original.Dispose();
            a.Dispose();
        }
        static void version5(String ubicacion, int depth, int size)
        {
            StreamWriter sw = new StreamWriter(@"./Txt/Tiempo5.txt");
            Bitmap original = new Bitmap(ubicacion);
            original.Save("./img/Version5-0.png");
            Bitmap a = original;
            Color c;

            long tiempo = 0;
            Stopwatch timeA = new Stopwatch();
            timeA.Restart();
            timeA.Start();
            for (int i = 0; i < a.Height - 2; i += 2)
            {
                for (int j = 0; j < a.Width - 2; j += 2)
                {
                    c = a.GetPixel(i, j);
                    c = Color.FromArgb(255, (255 - c.R), (255 - c.G), (255 - c.B));
                    a.SetPixel(i, j, c);

                    c = a.GetPixel(i, j + 1);
                    c = Color.FromArgb(255, (255 - c.R), (255 - c.G), (255 - c.B));
                    a.SetPixel(i, j + 1, c);

                    c = a.GetPixel(i + 1, j);
                    c = Color.FromArgb(255, (255 - c.R), (255 - c.G), (255 - c.B));
                    a.SetPixel(i + 1, j, c);

                    c = a.GetPixel(i + 1, j + 1);
                    c = Color.FromArgb(255, (255 - c.R), (255 - c.G), (255 - c.B));
                    a.SetPixel(i + 1, j + 1, c);
                }
            }
            timeA.Stop();

            tiempo = (long)(timeA.Elapsed.TotalMilliseconds * 1000000); //*1000000 ns; *1000 us
            Console.WriteLine("Tiempo " + tiempo);
            sw.WriteLine("Version 5; " + a.Height + "x" + a.Width + "; " + tiempo);
            sw.Close();
            a.Save("./inv/version5/" + depth + "-" + size + ".jpg", ImageFormat.Jpeg);
            original.Dispose();
            a.Dispose();
        }
    }
}
