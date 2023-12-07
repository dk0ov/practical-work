/* Задание 1.
using System;
using System.IO;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string pathInput = @"C:\Users\gr622_sedse\Desktop\практика 1\лабораторная 1.5\numsTask1.txt";
            StreamReader readInput = new StreamReader(pathInput);
            string[] input = readInput.ReadLine().Split(' ');
            int[] nums = new int[input.Length];
            
            for (int i = 0; i < input.Length; i++)
            {
                nums[i] = int.Parse(input[i]);
            }

            int min = nums[0];
            int indexOfMin = 0;
            int work = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                    indexOfMin = i;
                }
            }

            for (int i = indexOfMin + 1; i < nums.Length; i++)
            {
                work = work * nums[i];
            }
            Console.WriteLine(work);
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
            string pathInput = @"C:\Users\gr622_sedse\Desktop\практика 1\лабораторная 1.5\numsTask2.txt";
            StreamReader readInput = new StreamReader(pathInput);
            string[] input = readInput.ReadLine().Split(';');
            float[] nums = new float[input.Length];
            
            readInput.Close();
            
            for (int i = 0; i < input.Length; i++)
            {
                nums[i] = float.Parse(input[i]);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        float z = nums[j];
                        nums[j]=nums[j+1];
                        nums[j + 1] = z;
                    }
                }
            }
            
            string[] massStr = new string [nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                massStr[i] = nums[i].ToString();
            }

            using (StreamWriter writer = new StreamWriter(pathInput))
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums.Length == i)
                    {
                        writer.Write($"{massStr[0]}");
                    }
                    else
                    {
                        writer.Write($"{massStr[i]};");
                    }
                }
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
        string[] file = File.ReadAllLines(@"C:\Users\gr622_sedse\Desktop\практика 1\лабораторная 1.5\numsTask3.txt");
        string[] lines = file[0].Split(' ');
        int[] nums = new int[lines.Length];

        for (int i = 0; i < lines.Length; i++)
        {
            nums[i] = Int32.Parse(lines[i]);
        }

        int minValue = nums[0];
        int indexOfMin = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < minValue)
            {
                minValue = nums[i];
                indexOfMin = i;
            }
        }

        float sum = 0;
        for (int i = 0; i <= indexOfMin; i++)
        {
            sum += nums[i];
        }

        float avgValue = 0;
        avgValue = sum / (indexOfMin + 1);
        Console.WriteLine(avgValue);
    }
}
*/
/* Задание 4.
namespace ConsoleApp1;

public class Program
{
    public static void Main(string[] args)
    {
        string[] file = File.ReadAllLines(@"C:\Users\gr622_sedse\Desktop\практика 1\лабораторная 1.5\numsTask4.txt");
        string[] lines = file[0].Split(' ');
        int[] nums = new int[lines.Length];

        for (int i = 0; i < lines.Length; i++)
        {
            nums[i] = Int32.Parse(lines[i]);
        }

        int maxValue = nums[0];
        int indexOfMax = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > maxValue)
            {
                maxValue = nums[i];
                indexOfMax = i;
            }
        }

        int sum = 0;
        sum = nums[indexOfMax - 1] + nums[indexOfMax + 1];
        Console.WriteLine(sum);
    }
}
*/
/* Задание 5.
namespace ConsoleApp1;

public class Program
{
    public static void Main(string[] args)
    {
        string[] file = File.ReadAllLines(@"C:\Users\gr622_sedse\Desktop\практика 1\лабораторная 1.5\numsTask5.txt");
        string[] lines = file[0].Split(' ');
        int[] nums = new int[lines.Length];

        for (int i = 0; i < lines.Length; i++)
        {
            nums[i] = Int32.Parse(lines[i]);
        }

        int minValue = nums[0];
        int indexOfMin = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < minValue)
            {
                minValue = nums[i];
                indexOfMin = i;
            }
        }
        
        int maxValue = nums[0];
        int indexOfMax = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > maxValue)
            {
                maxValue = nums[i];
                indexOfMax = i;
            }
        }

        float sum = 0;
        int quantity = 0;
        for (int i = indexOfMin; i < indexOfMax + 1; i++)
        {
            sum += nums[i];
            quantity++;
        }

        float avgValue = sum / quantity;
        Console.WriteLine(avgValue);
    }
}
*/