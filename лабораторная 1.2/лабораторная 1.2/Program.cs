/* Задание 1.
namespace ConsoleApp1;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Введите начальное значение: ");
        int a = Int32.Parse(Console.ReadLine());
        int[] arr = new int[100];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = a;
            a -= 3;
        }
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}
*/
/* Задание 2.
namespace ConsoleApp1;

public class Program
{
    public static void Main(string[] args)
    {
        int[] arr = new int[100];
        int a = 1;
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = a;
            a += 2;
        }
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
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
        Console.WriteLine("Введите длину строки и столбца: ");
        int n = Int32.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[0, j] = 1;
                matrix[i, 0] = 1;
            }
        }

        for (int i = 1; i < n; i++)
        {
            for (int j = 1; j < n; j++)
            {
                matrix[i, j] = matrix[i - 1, j] + matrix[i, j - 1];
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{matrix[i, j], -5} ");
            }
            Console.WriteLine();
        }
    }
} 
*/
/* Задание 4.
namespace ConsoleApp1;

public class Program
{
    static int[] avgTemperature(int[,] temperature)
    {
        int[] avgTemps = new int[12];
        int sum = 0;

        for (int i = 0; i < 12; i++)
        {
            sum = 0;
            for (int j = 0; j < 30; j++)
            {
                sum += temperature[i, j];
            }

            avgTemps[i] = sum / 30;

        }

        return avgTemps;
    }
    
    public static void Main(string[] args)
    {
        int[,] temperature = new int[12, 30];
        int min = -30;
        int max = -9;
        Random random = new Random();

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 30; j++)
            {
                temperature[i, j] = random.Next(min, max);
            }

            if (i < 6)
            {
                min += 6;
                max += 7;
            }

            if (i > 6)
            {
                min -= 12;
                max -= 11;
            }

        }
        
        int[] avgTemps = avgTemperature(temperature);
        for (int i = 0; i < 12; i++)
        {
            Array.Sort(avgTemps);
            Console.WriteLine(avgTemps[i] + "°C");
        }
    }
}
*/
/* Задание 5.
namespace ConsoleApp1;

using System.Collections.Generic;

public class Program
{
    static Dictionary<string, int> AvgTemperature(Dictionary<string, int[]> temps)
    {
        Dictionary<string, int> averageTemperature = new Dictionary<string, int>();
        int sum = 0;

        foreach (var month in temps)
        {
            for (int i = 0; i < 30; i++)
            {
                sum += temps[month.Key][i];
            }

            sum /= 30;
            
            averageTemperature.Add(month.Key, sum);

            sum = 0;
        }

        return averageTemperature;
    }
    
    public static void Main(string[] args)
    {
        var temps = new Dictionary<string, int[]>()
        {
            ["January"] = new int[30],
            ["February"] = new int[30],
            ["March"] = new int[30],
            ["April"] = new int[30],
            ["May"] = new int[30],
            ["June"] = new int[30],
            ["July"] = new int[30],
            ["August"] = new int[30],
            ["September"] = new int[30],
            ["October"] = new int[30],
            ["November"] = new int[30],
            ["December"] = new int[30],
        };
        
        int min = -30;
        int max = -9;
        int monthNum = 0;
        Random rand = new Random();

        foreach (var month in temps)
        {
            for (int i = 0; i < 30; i++)
            {
                temps[month.Key][i] = rand.Next(min, max);
            }
            
            if (monthNum < 6)
            {
                min += 6;
                max += 7;
            }

            if (monthNum > 6)
            {
                min -= 12;
                max -= 11;
            }

            monthNum++;
        }

        var values = AvgTemperature(temps);

        foreach (var v in values)
        {
            Console.Write($"{v.Key} ");
            Console.WriteLine(v.Value + "°C");
        }
    }
}
*/