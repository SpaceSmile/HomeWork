namespace Hw3Task2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число от 0 до 100: ");
        int number = int.Parse(Console.ReadLine());
        
        switch (number)
        {
            case >= 0 and <= 14:
                Console.WriteLine($"{number} входит в промежуток [0 - 14]");
                break;

            case >= 15 and <= 35:
                Console.WriteLine($"{number} входит в промежуток [15 - 35]");
                break;

            case >= 36 and <= 50:
                Console.WriteLine($"{number} входит в промежуток [36 - 50]");
                break;

            case >= 51 and <= 100:
                Console.WriteLine($"{number} входит в промежуток [51 - 100]");
                break;

            default:
                Console.WriteLine($"{number} не входит ни в один из промежутков [0 - 100]");
                break;
        }
    }
}