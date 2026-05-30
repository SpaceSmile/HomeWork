namespace Hw2Task3;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите слово на русском: ");
        string word = Console.ReadLine();

        switch (word)
        {
            case "погода":
                Console.WriteLine("weather");
                break;
            case "дождь":
                Console.WriteLine("rain");
                break;
            case "снег":
                Console.WriteLine("snow");
                break;
            case "солнце":
                Console.WriteLine("sun");
                break;
            case "ветер":
                Console.WriteLine("wind");
                break;
            case "туман":
                Console.WriteLine("fog");
                break;
            case "гроза":
                Console.WriteLine("thunderstorm");
                break;
            case "облако":
                Console.WriteLine("cloud");
                break;
            case "мороз":
                Console.WriteLine("frost");
                break;
            case "радуга":
                Console.WriteLine("rainbow");
                break;
            default:
                Console.WriteLine($"{word} не найдено в словаре.");
                break;
        }
    }
}