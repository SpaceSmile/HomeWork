namespace Hw5Task2;

class Program
{
    static void Main(string[] args)
	{
		string text = "teamwithsomeofexcersicesabcwanttomakeitbetter";
		string marker = "abc";
		int index = text.IndexOf(marker);

		if (index >= 0)
		{
			string before = text.Substring(0, index);
			string after = text.Substring(index + marker.Length);

			Console.WriteLine("До 'abc': " + before);
			Console.WriteLine("После 'abc': " + after);
		}
		else
		{
			Console.WriteLine("Подстрока 'abc' не найдена.");
		}
	}
}