namespace Hw4Task5;

class Program
{
    static void Main(string[] args)
	{
		int[,] massive = {
			{ 1,  2,  3 },
			{ 4,  5,  6 },
			{ 7,  8,  9 }
		};
        Console.Write("Диагональ: ");
        for (int i = 0; i < massive.GetLength(0); i++)
            Console.Write(massive[i, i] + " ");
	}
}