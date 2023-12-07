/* Задание 1.
using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] fileTickets = File.ReadAllLines(@"C:\Users\gr622_sedse\Desktop\практика 1\лабораторная 1.3\input.txt");
            string[] luckyNumbers = fileTickets[0].Split(' ');
            int quantity = int.Parse(fileTickets[1]);
            List<string> result = new List<string>();

            for (int i = 2; i < 2 + quantity; i++)
            {
                int count = 0;
                string[] ticketNum = fileTickets[i].Split(' ');
                foreach (string num1 in ticketNum)
                {
                    foreach (string num2 in luckyNumbers)
                    {
                        if (num1 == num2)
                        {
                            count++;
                            break;
                        }
                    }
                }

                if (count >= 3)
                {
                    result.Add("Lucky");
                }
                else
                {
                    result.Add("Unlucky");
                }
            }
            File.WriteAllLines( @"C:\Users\gr622_sedse\Desktop\практика 1\лабораторная 1.3\output.txt", result.ToArray());
        }
    }
}
*/
/* Задание 2.
using System;
using System.IO;

namespace ConsoleApp1;

public class Program
{
    public static void Main(string[] args)
    {
        string[] file = File.ReadAllLines(@"C:\Users\gr622_sedse\Desktop\практика 1\лабораторная 1.3\nums.txt");
        string file1 = @"C:\Users\gr622_sedse\Desktop\практика 1\лабораторная 1.3\nums.txt";
        string[] lines = file[0].Split(' ');
        int[] nums = new int[lines.Length];

        for (int i = 0; i < lines.Length; i++)
        {
            nums[i] = Int32.Parse(lines[i]);
        }

        int newNums = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 != 0)
            {
                newNums++;
            }
        }

        int[] newNumsArr = new int[newNums];
        int index = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] % 2 != 0)
            {
                newNumsArr[index] = nums[i];
                index++;
            }
        }
        
        for (int i = 0; i < newNums; i++)
        {
            Console.Write(newNumsArr[i] + " ");
        }
        
        using (StreamWriter writer = new StreamWriter(file1))
        {
            for (int i = 0; i < newNumsArr.Length; i++)
            {
                if (i == 0)
                {
                    writer.Write($"{newNumsArr[0]}");
                }
                else
                {
                    writer.Write($"{newNumsArr[i]}");
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
            string pathInput = @"C:\Users\gr622_sedse\Desktop\практика 1\лабораторная 1.3\height.txt";
            int[] height;
            StreamReader readInput = new StreamReader(pathInput);
            string[] input = readInput.ReadLine().Split(' ');
            height = new int [input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                height[i] = int.Parse(input[i]);
            }
            
            int square = 0;
            int distance = 0;
            int minimumWallProduct = 0;
            int line1 = 0;
            int line2 = 0;
            int distanceOutput = 0;
            
            for (int i = 0; i < height.Length; i++)
            {
                for (int j = 0; j < height.Length; j++)
                {
                    distance = (j - i) - 1;
                    
                    if (height[i] > height[j])
                    {
                        if ((height[j] * height[j] * distance) > square)
                        {
                            square = (height[j] * height[j] * distance);
                            line1 = height[i];
                            line2 = height[j];
                            distanceOutput = distance;
                            minimumWallProduct = height[j] * height[j];
                        }
                    }
                    else
                    {
                        if ((height[i] * height[i] * distance) > square)
                        {
                            square = (height[i] * height[i] * distance);
                            line1 = height[i];
                            line2 = height[j];
                            distanceOutput = distance;
                            minimumWallProduct = height[i] * height[i];
                        }
                    }
                }
            }
            Console.WriteLine("output: " + minimumWallProduct);
            Console.WriteLine("lines: " + line1 + "; " + line2);
            Console.WriteLine("distance: " + distanceOutput);
        }
    }
}
*/