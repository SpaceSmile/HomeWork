namespace Hw5Task1;

class Program
{
    static void Main(string[] args)
	{
		string text = "test123 and test45.";
		string replaced = text.Replace("test", "testing");
		string result = new string(replaced.Where(c => !char.IsDigit(c)).ToArray());

		Console.WriteLine("Исходная строка: " + text);
		Console.WriteLine("После замены и удаления цифр: " + result);
	}
}