/* Задание 1.
namespace ConsoleApp1;

public class Program
{
    public static void Main(string[] args)
    {
        
        int[] arr = new int[10];
        Random rand = new Random();
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rand.Next(1, 100);
        }
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }

        int minVal = arr.Min();
        int indexMin = Array.IndexOf(arr, minVal);
        
        Console.WriteLine($"Минимальное число: " + minVal);
        Console.WriteLine($"Индекс минимального числа: " + indexMin);
    }
}
*/
/* Задание 2.
namespace ConsoleApp1;

public class Program
{
    public static void Main(string[] args)
    {
        List<int> nums = new List<int>();
        int num = Int32.Parse(Console.ReadLine());
        int sum = 0;
        int mult = 1;

        while (num != 0)
        {
            nums.Add(num);
            sum += num;
            mult *= num;
            num = Int32.Parse(Console.ReadLine());
        }
        int ovg = sum / nums.Count;
        
        Console.WriteLine($"Сумма чисел: {sum} \n" + $"Произведение чисел: {mult} \n" + $"Среднее: {ovg}");
    }
}
*/
/* Задание 3.
namespace ConsoleApp1;

public class Program
{
    public static void Main(string[] args)
    {
        List<string> words = new List<string>();
        string word = Console.ReadLine();
        string shortestWord = word;
        string longestWord = word;

        while (word != "")
        {
            words.Add(word);
            if (word.Length < shortestWord.Length)
            {
                shortestWord = word;
            }
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }
            word = Console.ReadLine();
        }
        
        Console.WriteLine($"Самый короткий элемент списка: {shortestWord} \n" + $"Самый длинный элемент списка: {longestWord}");  
        
    }
}
*/
/* Задание 4.
namespace ConsoleApp1;

public class Program
{
    static int[] randomNumbers(int a, int b)
    {
        Console.WriteLine("Введите количество элементов массива: ");
        int n = Int32.Parse(Console.ReadLine());
        int[] nums = new int[n];
        Random rand = new Random();

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = rand.Next(a, b + 1);
        }

        return nums;
    }
    
    public static void Main()
    {
        Console.Write("Введите начальное значение диапазона: ");
        int a = Int32.Parse(Console.ReadLine());
        Console.Write("Введите конечное значение диапазона: ");
        int b = Int32.Parse(Console.ReadLine());
        
        int[] arr = randomNumbers(a, b);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"{arr[i]} ");
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
        Console.WriteLine("Введите строку: ");
        string line = Console.ReadLine();
        string[] words = line.Split(new char[] { ' ' });
        
        Console.WriteLine("Количество слов в строке: " + words.Length);
        Console.WriteLine("Start " + line + " End");
    }
}
*/