namespace Hw4Task2;

class Program
{
    static void Main(string[] args)
	{
        int [] massive = { 1, 50, 30 };
        Console.Write("Введите число для удаления: ");
		int? numbers = int.Parse(Console.ReadLine());
		if (Array.IndexOf(massive, numbers) < 0)
		{
			Console.WriteLine("Такого числа нет в массиве");
			return;
		}

		int[] result = Array.FindAll(massive, n => n != numbers);
		Console.WriteLine("Новый массив: " + string.Join(", ", result));
	}
}