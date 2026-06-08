namespace Hw5Task3;

class Program
{
    static void Main(string[] args)
	{
		string text = "Плохой день.";
		string withoutBadWord = text.Substring("Плохой ".Length);
		withoutBadWord = withoutBadWord.Substring(0, withoutBadWord.Length - 1);
		string goodDay = withoutBadWord.Insert(0, "Хороший ");
		goodDay = goodDay + "!!!!!!!!!";
		goodDay = goodDay.Substring(0, goodDay.Length - 1) + "?";
		Console.WriteLine(goodDay);
	}
}