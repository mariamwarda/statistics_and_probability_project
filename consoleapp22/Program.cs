using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of numbers");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the numbers");
            float[] z = new float[x];
            float m = z[0];
            //enter the array
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("enter n{0}", i + 1);
                float a = float.Parse(Console.ReadLine());
                z[i] = a;
            }
            //print the array 
            Array.Sort(z);
            for (int g = 0; g < z.Length; g++)
            {
                Console.WriteLine("index {0} =" + z[g], g + 1);
            }
            //the median
            if (x % 2 == 0)
            {
                Console.WriteLine("The Median1= {0}", (z[(x / 2) - 1] + z[x / 2]) / 2);
            }
            else
            {
                Console.WriteLine("The median1= {0}", z[(x + 1) / 2 - 1]);
            }
            //the range
            Console.WriteLine("The Rang=" + (z[x - 1] - z[0]));
            //the first quartil
            int n = x / 2;
            int f = (x + 1) / 2;
            float k= z[(n / 2) - 1] + z[n / 2] / 2;
            float l = z[(n + 1) / 2 - 1];
            float o = (z[(f / 2) - 1] + z[f / 2]) / 2;
            float p = z[(f + 1) / 2 - 1];
            if (x % 2 == 0)
            {
                for (int c = 0; c < n; c++)
                {
                    if (n % 2 == 0)
                    {
                        Console.WriteLine("The median2 ={0}",k);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The median2 = {0}",l);
                        break;
                    }
                }
            }
            else
            {
                for (int w = 0; w < f; w++)
                {
                    if (f % 2 == 0)
                    {
                        Console.WriteLine("The median3 ={0}",o);
                        break;

                    }
                    else
                    {
                        Console.WriteLine("The median3 = {0}",p);
                        break;
                    }
                }
            }
            //the third quartil
            int d = n + 1;
            int e =( (x - n) / 2)+1;
            int h = x - n;
            float q = (z[(e / 2) + 1] + z[e / 2]) / 2;
            float s = z[(e + 1) / 2 - 1];
            float t = (z[(h / 2) - 1] + z[h / 2]) / 2;
            float u = z[(h + 1) / 2 - 1];
            if (x % 2 == 0)
            {
                for (int b = d; b < x; b++)
                {
                    if (e % 2 == 0)
                    {
                        Console.WriteLine("The median4 ={0}",q);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The median4 = {0}",s);
                        break;
                    }
                }
            }
            else
            {
                for (int j = f; j < x; j++)
                {
                    if (h % 2 == 0)
                    {
                        Console.WriteLine("The median5 ={0}",t);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The median5 = {0}",u);
                        break;
                    }
                }
            }
            //the 90%
            Console.WriteLine("P90=" + (x + 1) * 0.9);
            //q3-q1
            float v = q - k;
            float y = s - l;
            float aa = t - o;
            float bb = u - p;
            Console.WriteLine("IQR");
            if (x % 2 == 0 && n % 2 == 0 && e % 2 == 0)
            {
                Console.WriteLine(v);
            }
            if (x % 2 == 0 && n % 2!= 0 && e % 2 != 0)
            {
                Console.WriteLine(y); 
            }
            if (x % 2 != 0 && f % 2 == 0 && h % 2 == 0)
            {
                Console.WriteLine(aa);
            }
            if (x % 2 != 0 && f % 2 != 0 && h % 2 != 0)
            { 
                Console.WriteLine(bb);
            }
            double cc = q + (1.5 * v);
            double dd = s + (1.5 * y);
            double ee = t + (1.5 * aa);
            double ff = u + (1.5 * bb);
            //the Upper Boundary
            Console.WriteLine("Upper Boundary");
            if (x % 2 == 0 && n % 2 == 0 && e % 2 == 0)
            {
                Console.WriteLine(cc);
            }
            if (x % 2 == 0 && n % 2 != 0 && e % 2 != 0)
            { 
                Console.WriteLine(dd);
            }
            if (x % 2 != 0 && f % 2 == 0 && h % 2 == 0)
            {
                Console.WriteLine(ee);
            }
            if (x % 2 != 0 && f % 2 != 0 && h % 2 != 0)
            { 
                Console.WriteLine(ff);
            }
            //the Lower Boundary
            Console.WriteLine("Lower Boundary");
            if (x % 2 == 0 && n % 2 == 0 && e % 2 == 0)
            {
                Console.WriteLine(k- (1.5 * v));
            }
            if (x % 2 == 0 && n % 2 != 0 && e % 2 != 0)
            {
                Console.WriteLine(l- (1.5 * y));
            }
            if (x % 2 != 0 && f % 2 == 0 && h % 2 == 0)
            {
                Console.WriteLine(o- (1.5 * aa));
            }
            if (x % 2 != 0 && f % 2 != 0 && h % 2 != 0)
            {
                Console.WriteLine(p- (1.5 * bb));
            }
            //determine if it is outlier
            if (cc > z[x - 1]||dd> z[x - 1]||ee> z[x-1]||ff> z[x-1])
            {
                Console.WriteLine("it is outlier");
            }
            else
            {
                Console.WriteLine("it is not outlier");
            }
            Console.ReadKey();
        }
    }
}