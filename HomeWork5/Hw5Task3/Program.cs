namespace Hw5Task3;

class Program
{
    static void Main(string[] args)
	{
		string text = "Плохой день.";

		// 1) Удаляем "Плохой" через Substring:
		// берем часть строки, начиная после "Плохой " (7 символов)
		string withoutBadWord = text.Substring("Плохой ".Length); // "день."

		// Убираем точку в конце, чтобы получить "день"
		withoutBadWord = withoutBadWord.Substring(0, withoutBadWord.Length - 1);

		// 2) Вставляем "Хороший " в начало через Insert
		string goodDay = withoutBadWord.Insert(0, "Хороший "); // "Хороший день"

		// Делаем нужное количество "!"
		goodDay = goodDay + "!!!!!!!!!"; // "Хороший день!!!!!!!!!"

		// 3) Заменяем последний "!" на "?"
		goodDay = goodDay.Substring(0, goodDay.Length - 1) + "?";

		Console.WriteLine(goodDay); // Хороший день!!!!!!!!?
	}
}