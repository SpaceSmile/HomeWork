namespace Hw3Task4;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int var1 = int.Parse(Console.ReadLine());

        switch (var1 % 2)
        {
            case 0:
                Console.WriteLine($"{var1} — чётное");
                break;
            default:
                Console.WriteLine($"{var1} — нечётное");
                break;
        }
        
        Console.Write("Введите число: ");
        int var2 = int.Parse(Console.ReadLine());

        if (var2 % 2 == 0)
            Console.WriteLine($"{var2} — чётное");
        else
            Console.WriteLine($"{var2} — нечётное");
    }
}