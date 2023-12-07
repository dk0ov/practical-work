/* Задание 1.
using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int multiple = 3;
            int work = 1;
            Console.Write("Введите число n: ");
            int n = int.Parse (Console.ReadLine());
            while (multiple < n)
            {
                work = multiple * work;
                multiple += 3;
            }

            Console.WriteLine($"Произведение натуральных чисел, кратных трем и не превышающих число n = {work}");
        }
    }
}
*/
/* Задание 2.
using System;
using System.IO;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string pathInput = @"C:\Users\gr622_sedse\Desktop\практика 1\лабораторная 1.4\numsTask2.txt";
            float[] nums;
            StreamReader readInput = new StreamReader(pathInput);
            string[] input = readInput.ReadLine().Split(';');
            nums = new float[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                nums[i] = float.Parse(input[i]);
            }

            float sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    Console.WriteLine(sum);
                }
                else
                {
                    if (nums[i] > 0)
                    {
                        sum = nums[i] + sum;
                    }
                }
            }
        }
    }
}
*/
/* Задание 3.
using System;
using System.IO;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string pathInput = @"C:\Users\gr622_sedse\Desktop\практика 1\лабораторная 1.4\numsTask3.txt";
            int[] nums;
            StreamReader readInput = new StreamReader(pathInput);
            string[] input = readInput.ReadLine().Split(',');
            nums = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                nums[i] = int.Parse(input[i]);
            }

            double max = 0;
            double min = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    double division = (min / max);
                    double division2 = (max / min);
                    Console.WriteLine("min / max = " + division);
                    Console.WriteLine("max / min = " + division2);
                }
                else
                {
                    if (nums[i] > max)
                    {
                        max = nums[i];
                    }
                    else
                    {
                        if (nums[i] < min)
                        {
                            min = nums[i];
                        }
                    }
                }
            }
        }
    }
}
*/
/* Задание 4.
using System;
using System.IO;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string pathInput = @"C:\Users\gr622_sedse\Desktop\практика 1\лабораторная 1.4\numsTask4.txt";
            int[] nums;
            StreamReader readInput = new StreamReader(pathInput);
            string[] input = readInput.ReadLine().Split(' ');
            nums = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                nums[i] = int.Parse(input[i]);
            }

            int sum = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] == nums[i])
                {
                    sum++;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
*/
/* Задание 5.
namespace ConsoleApp1;

public class Program
{
    public static void Main(string[] args)
    {
        double x1 = -1.0;
        double x2 = 3.0;
        double y1 = -2.0;
        double y2 = 4.0;
        
        Console.Write("Введите координату a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введите координату b: ");
        double b = double.Parse(Console.ReadLine());

        if (a > x1 & a < x2)
        {
            if (b > y1 & b < y2)
            {
                Console.WriteLine("Точка с данными координатами входит в заштрихованную область.");
            }
            else
            {
                Console.WriteLine("Точка с данными координатами не входит в заштрихованную область.");
            }
        }
        else
        {
            Console.WriteLine("Точка с данными координатами не входит в заштрихованную область.");
        }
    }
}
*/
/* Задание 6.
namespace ConsoleApp1;

public class Program
{
    public static void Main(string[] args)
    {
        int[] x = new int[4] {0, 0, 2, -2};
        int[] y = new int[4] {0, 2, -3, -3};
        Console.WriteLine("Введите координаты точки:");
        Console.WriteLine("x = ");
        x[0] = int.Parse(Console.ReadLine());
        Console.WriteLine("y = ");
        y[0] = int.Parse(Console.ReadLine());

        int a = (x[1] - x[0]) * (y[2] - y[1]) - (x[2] - x[1]) * (y[1] - y[0]);
        int b = (x[2] - x[0]) * (y[3] - y[2]) - (x[3] - x[2]) * (y[2] - y[0]);
        int c = (x[3] - x[0]) * (y[1] - y[3]) - (x[1] - x[3]) * (y[3] - y[0]);

        if ((a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0))
        {
            Console.WriteLine("Точка принадлежит закрашенной области");
        }
        else
        {
            Console.WriteLine("Точка не принадлежит закрашенной области");
        }
    }
}
*/