namespace Hw4Task3;

class Program
{
    static void Main(string[] args)
	{
		Console.Write("Введите размер массива: ");
		int size = int.Parse(Console.ReadLine());

		Random random = new Random();
		int[] massive = new int[size];

		for (int i = 0; i < size; i++)
			massive[i] = random.Next(1, 50);

		Console.WriteLine("Массив: " + string.Join(", ", massive));

		int max = massive[0];
		int min = massive[0];
		int sum = 0;

		for (int i = 0; i < massive.Length; i++)
		{
			if (massive[i] > max)
				max = massive[i];

			if (massive[i] < min)
				min = massive[i];

			sum += massive[i];
		}

		double average = (double)sum / massive.Length;

		Console.WriteLine("Максимальное: " + max);
		Console.WriteLine("Минимальное: " + min);
		Console.WriteLine("Среднее: " + average);
	}
}