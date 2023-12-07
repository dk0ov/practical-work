/* Задание 1.
using System;
using System.IO;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string pathInput = @"C:\Users\gr622_sedse\Desktop\практика 1\лабораторная 1.6\numsTask1.txt";
            StreamReader readInput = new StreamReader(pathInput);
            string[] input = readInput.ReadLine().Split(' ');

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length % 2 != 0)
                    Console.Write($"{input[i]} ");
            }
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
            string pathInput = @"C:\Users\gr622_sedse\Desktop\практика 1\лабораторная 1.6\numsTask2.txt";
            string[] lines = File.ReadAllLines(pathInput);
            for (int i = 0; i < lines.Length; i++)
            {
                Console.Write($"{lines[i]} "); 
            }
        }
    } 
}
*/
/* Задание 3.
namespace ConsoleApp1;

public class Program
{
    public static void Main(string[] args)
    {
        int a = 0;
        Console.WriteLine("Введите число: ");
        a = int.Parse(Console.ReadLine());

        if ((a % 2 == 0) && (a % 10 == 0))
        {
            Console.WriteLine($"Число {a} является четным и кратным 10");
        }
        else
        {
            Console.WriteLine($"Число {a} не является четным и кратным 10");
        }
    }
}
*/
/* Задание 4.
namespace ConsoleApp1;

public class Program
{
    public static void Main(string[] args)
    {
        int[] nums = new int[10];
        Console.WriteLine("Введите положительные числа: ");
        for (int i = 0; i < 10; i++)
        {
            Console.Write("[" + i + "] = ");
            nums[i] = int.Parse(Console.ReadLine());
        }
        
        int a = 0;
        Console.Write("Введите положительное число a: ");
        a = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if ((nums[i] % a == 0) && (a > 0))
            {
                sum += nums[i];
            }
        }
        Console.WriteLine($"Сумма чисел, которые делятся нацело на число {a} равна {sum}");
        if (a < 0)
        {
            Console.WriteLine("Завершение работы");
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
        int n, m;
        Random rand = new Random();
        n = rand.Next(5, 10);
        m = rand.Next(5, 10);
        int[,] a = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m - 1; j++)
            {
                a[i, j] = rand.Next(0, 2);
            }
        }

        int[] quantity1 = new int[n];
        
        int counter1 = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (a[i, j] == 1)
                {
                    counter1++;
                }
            }
            quantity1[i] = counter1;
            counter1 = 0;
        }

        for (int i = 0; i < n; i++)
        {
            if (quantity1[i] % 2 != 0)
            {
                a[i, m-1] = 1;
            }
        }
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"{a[i, j],-5} ");
            }
            Console.WriteLine();
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
        int a;
        Random rand = new Random();
        a = rand.Next(0, 100);
        float[] nums = new float[a];

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = rand.Next(-100, 100);
        }

        int counterPositive = 0;
        int counterNegative = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {
                counterPositive++;
            }
            else if (nums[i] < 0)
            {
                counterNegative++;
            }
        }

        float[] positive = new float[counterPositive];
        float[] negative = new float[counterNegative];
        int p = 0;
        int n = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
            {
                positive[p] = nums[i];
                p++;
            }
            else
            {
                if (nums[i] < 0)
                {
                    negative[n] = nums[i];
                    n++;
                }
            }
        }

        Console.WriteLine("Массив положительных чисел: ");
        for (int i = 0; i < positive.Length; i++)
        {
            Console.Write(positive[i] + " ");
        }
        Console.WriteLine("\n");
        Console.WriteLine("Массив отрицательных чисел: ");
        for (int i = 0; i < negative.Length; i++)
        {
            Console.Write(negative[i] + " ");
        }
    }
}
*/