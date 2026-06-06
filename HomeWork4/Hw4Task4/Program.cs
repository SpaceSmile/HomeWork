namespace Hw4Task4;

class Program
{
    static void Main(string[] args)
	{
		int[,] massive = {
			{ 1,  1,  1 },
			{ 1,  1,  1 },
			{ 1,  1,  1 }
		};
		
		int sum = 0;
		for (int i = 0; i < massive.GetLength(0); i++)
		{
			for (int j = 0; j < massive.GetLength(1); j++)
			{
				sum += massive[i, j];
			}
		}
		Console.WriteLine("Сумма всех элементов: " + sum);
	}
}