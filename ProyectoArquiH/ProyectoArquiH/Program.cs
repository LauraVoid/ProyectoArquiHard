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

            
            Console.WriteLine("Version (1,2,3,4,5)");
            String ver = Console.ReadLine();
            int version = int.Parse(ver);
            Console.WriteLine("size (64,160,512,1500)");
            String si = Console.ReadLine();
            int size = int.Parse(si);
            Console.WriteLine("depth (16,24,48)");
            String dep = Console.ReadLine();
            int depth = int.Parse(dep);

            String imagen6424 = "./Imagenes/tif/64/24.tif";
            String imagen16024 = "./Imagenes/tif/160/24.tif";
            String imagen51224 = "./Imagenes/tif/512/24.tif";
            String imagen150024 = "./Imagenes/1500/24.tif";

            String imagen6448 = "./Imagenes/tif/64/48.tif";
            String imagen16048 = "./Imagenes/tif/160/48.tif";
            String imagen51248 = "./Imagenes/tif/512/48.tif";
            String imagen150048 = "./Imagenes/tif/1500/48.tif";

            String imagen6416 = "./Imagenes/tif/64/16.tif";
            String imagen16016 = "./Imagenes/tif/160/16.tif";
            String imagen51216 = "./Imagenes/tif/512/16.tif";
            String imagen150016 = "./Imagenes/tif/1500/16.tif";
            switch (version)
            {
                case 1:
                    if (size == 64)
                    {
                        if (depth == 16)
                        {
                            version1(imagen6416, depth, size);
                        }
                        if (depth == 24)
                        {
                            version1(imagen6424, depth, size);
                        }
                        if (depth == 48)
                        {
                            version1(imagen6448, depth, size);
                        }

                    }
                    if (size == 160)
                    {
                        if (depth == 16)
                        {
                            version1(imagen16016, depth, size);
                        }
                        if (depth == 24)
                        {
                            version1(imagen16024, depth, size);
                        }
                        if (depth == 48)
                        {
                            version1(imagen16048, depth, size);
                        }

                    }
                    if (size == 512)
                    {
                        if (depth == 16)
                        {
                            version1(imagen51216, depth, size);
                        }
                        if (depth == 24)
                        {
                            version1(imagen51224, depth, size);
                        }
                        if (depth == 48)
                        {
                            version1(imagen51248, depth, size);
                        }

                    }
                    if (size == 1500)
                    {
                        if (depth == 16)
                        {
                            version1(imagen150016, depth, size);
                        }
                        if (depth == 24)
                        {
                            version1(imagen150024, depth, size);
                        }
                        if (depth == 48)
                        {
                            version1(imagen150048, depth, size);
                        }

                    }
                    break;
                case 2:
                    if (size == 64)
                    {
                        if (depth == 16)
                        {
                            version2(imagen6416, depth, size);
                        }
                        if (depth == 24)
                        {
                            version2(imagen6424, depth, size);
                        }
                        if (depth == 48)
                        {
                            version2(imagen6448, depth, size);
                        }

                    }
                    if (size == 160)
                    {
                        if (depth == 16)
                        {
                            version2(imagen16016, depth, size);
                        }
                        if (depth == 24)
                        {
                            version2(imagen16024, depth, size);
                        }
                        if (depth == 48)
                        {
                            version2(imagen16048, depth, size);
                        }

                    }
                    if (size == 512)
                    {
                        if (depth == 16)
                        {
                            version2(imagen51216, depth, size);
                        }
                        if (depth == 24)
                        {
                            version2(imagen51224, depth, size);
                        }
                        if (depth == 48)
                        {
                            version2(imagen51248, depth, size);
                        }

                    }
                    if (size == 1500)
                    {
                        if (depth == 16)
                        {
                            version2(imagen150016, depth, size);
                        }
                        if (depth == 24)
                        {
                            version2(imagen150024, depth, size);
                        }
                        if (depth == 48)
                        {
                            version2(imagen150048, depth, size);
                        }

                    }
                    break;

                case 3:
                    if (size == 64)
                    {
                        if (depth == 16)
                        {
                            version3(imagen6416, depth, size);
                        }
                        if (depth == 24)
                        {
                            version3(imagen6424, depth, size);
                        }
                        if (depth == 48)
                        {
                            version3(imagen6448, depth, size);
                        }

                    }
                    if (size == 160)
                    {
                        if (depth == 16)
                        {
                            version3(imagen16016, depth, size);
                        }
                        if (depth == 24)
                        {
                            version3(imagen16024, depth, size);
                        }
                        if (depth == 48)
                        {
                            version3(imagen16048, depth, size);
                        }

                    }
                    if (size == 512)
                    {
                        if (depth == 16)
                        {
                            version3(imagen51216, depth, size);
                        }
                        if (depth == 24)
                        {
                            version3(imagen51224, depth, size);
                        }
                        if (depth == 48)
                        {
                            version3(imagen51248, depth, size);
                        }

                    }
                    if (size == 1500)
                    {
                        if (depth == 16)
                        {
                            version3(imagen150016, depth, size);
                        }
                        if (depth == 24)
                        {
                            version3(imagen150024, depth, size);
                        }
                        if (depth == 48)
                        {
                            version3(imagen150048, depth, size);
                        }

                    }
                    break;

                case 4:
                    if (size == 64)
                    {
                        if (depth == 16)
                        {
                            version4(imagen6416, depth, size);
                        }
                        if (depth == 24)
                        {
                            version4(imagen6424, depth, size);
                        }
                        if (depth == 48)
                        {
                            version4(imagen6448, depth, size);
                        }

                    }
                    if (size == 160)
                    {
                        if (depth == 16)
                        {
                            version4(imagen16016, depth, size);
                        }
                        if (depth == 24)
                        {
                            version4(imagen16024, depth, size);
                        }
                        if (depth == 48)
                        {
                            version4(imagen16048, depth, size);
                        }

                    }
                    if (size == 512)
                    {
                        if (depth == 16)
                        {
                            version4(imagen51216, depth, size);
                        }
                        if (depth == 24)
                        {
                            version4(imagen51224, depth, size);
                        }
                        if (depth == 48)
                        {
                            version4(imagen51248, depth, size);
                        }

                    }
                    if (size == 1500)
                    {
                        if (depth == 16)
                        {
                            version4(imagen150016, depth, size);
                        }
                        if (depth == 24)
                        {
                            version4(imagen150024, depth, size);
                        }
                        if (depth == 48)
                        {
                            version4(imagen150048, depth, size);
                        }

                    }
                    break;

                case 5:
                    if (size == 64)
                    {
                        if (depth == 16)
                        {
                            version5(imagen6416, depth, size);
                        }
                        if (depth == 24)
                        {
                            version5(imagen6424, depth, size);
                        }
                        if (depth == 48)
                        {
                            version5(imagen6448, depth, size);
                        }

                    }
                    if (size == 160)
                    {
                        if (depth == 16)
                        {
                            version5(imagen16016, depth, size);
                        }
                        if (depth == 24)
                        {
                            version5(imagen16024, depth, size);
                        }
                        if (depth == 48)
                        {
                            version5(imagen16048, depth, size);
                        }

                    }
                    if (size == 512)
                    {
                        if (depth == 16)
                        {
                            version5(imagen51216, depth, size);
                        }
                        if (depth == 24)
                        {
                            version5(imagen51224, depth, size);
                        }
                        if (depth == 48)
                        {
                            version5(imagen51248, depth, size);
                        }

                    }
                    if (size == 1500)
                    {
                        if (depth == 16)
                        {
                            version5(imagen150016, depth, size);
                        }
                        if (depth == 24)
                        {
                            version5(imagen150024, depth, size);
                        }
                        if (depth == 48)
                        {
                            version5(imagen150048, depth, size);
                        }

                    }
                    break;
              default:                         
                 salir = false;
                  break;
            }
            }
        }
        static Bitmap ChangePixelFormat(Bitmap inputImage, PixelFormat newFormat)
        {
            Bitmap bmp = new Bitmap(inputImage.Width, inputImage.Height, newFormat);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawImage(inputImage, new Rectangle(0, 0, inputImage.Width, inputImage.Height));
            }
            return bmp;
        }
        static void version1(String ubicacion, int depth, int size)
        {
            StreamWriter sw = new StreamWriter("./Txt/Tiempo1.txt");
            Console.WriteLine(ubicacion);
            Bitmap original = new Bitmap(ubicacion);
            original.Save("./img/Version1-0.png");
            Bitmap a =original;
           
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

            a.Save("./inv/version1/" + depth + "-" + size + ".tif", ImageFormat.Tiff);
            original.Dispose();
            a.Dispose();
        }
        static void version2(String ubicacion, int depth, int size)
        {
            StreamWriter sw = new StreamWriter("./Txt/Tiempo2.txt");
            Console.WriteLine(ubicacion);
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
            a.Save("./inv/version2/" + depth + "-" + size + ".tif", ImageFormat.Tiff);
            original.Dispose();
            a.Dispose();
           
        }
        static void version3(String ubicacion, int depth, int size)
        {
            StreamWriter sw = new StreamWriter("./Txt/Tiempo3.txt");
            Console.WriteLine(ubicacion);
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
            a.Save("./inv/version3/" + depth + "-" + size + ".tif", ImageFormat.Tiff);
            original.Dispose();
            a.Dispose();
        }
        static void version4(String ubicacion, int depth, int size)
        {
            StreamWriter sw = new StreamWriter("./Txt/Tiempo4.txt");
            Console.WriteLine(ubicacion);
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
            a.Save("./inv/version4/" + depth +"-"+ size+ ".tif", ImageFormat.Tiff);
            original.Dispose();
            a.Dispose();
        }
        static void version5(String ubicacion, int depth, int size)
        {
            StreamWriter sw = new StreamWriter("./Txt/Tiempo5.txt");
            Console.WriteLine(ubicacion);
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
            a.Save("./inv/version5/" + depth + "-" + size + ".tif", ImageFormat.Tiff);
            original.Dispose();
            a.Dispose();
        }
    }
}
