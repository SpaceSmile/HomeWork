namespace Hw4Task1;

class Program
{
    static void Main(string[] args)
	{
        int [] massive = { 1, 50, 30 };
		int? numbers = int.Parse(Console.ReadLine());
		bool found = false;
		foreach ( int n in massive)
		{
			if (n == numbers)
            {
                found = true;
                break;
            }
        }
		if (found)
			Console.WriteLine("Число найдено");
		else
			Console.WriteLine("Число не найдено");
	}
}