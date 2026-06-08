using System.Text;

namespace Hw5Task4;

class Program
{
    static void Main(string[] args)
	{
        Console.Write("Введите номер документа (xxxx-yyy-xxxx-yyy-xyxy): ");
        string? doc = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(doc))
        {
            Console.WriteLine("Пустой ввод.");
            return;
        }

        string[] parts = doc.Split('-');
        if (parts.Length != 5)
        {
            Console.WriteLine("Неверный формат. Ожидается 5 блоков через дефис.");
            return;
        }
        Console.WriteLine($"Первые два цифровых блока: {parts[0]} {parts[2]}");

        string masked = $"{parts[0]}-***-{parts[2]}-***-{parts[4]}";
        Console.WriteLine($"Замаскированный документ: {masked}");

        string lettersLower = $"{parts[1]}/{parts[3]}/{parts[4][1]}/{parts[4][3]}".ToLower();
        Console.WriteLine($"Буквы (lower): {lettersLower}");

        StringBuilder sb = new StringBuilder();
        sb.Append("Letters:");
        sb.Append(parts[1]);
        sb.Append('/');
        sb.Append(parts[3]);
        sb.Append('/');
        sb.Append(parts[4][1]);
        sb.Append('/');
        sb.Append(parts[4][3]);

        string lettersUpper = sb.ToString().ToUpper();
        Console.WriteLine(lettersUpper);

        bool containsAbc = doc.IndexOf("abc", StringComparison.OrdinalIgnoreCase) >= 0;
        Console.WriteLine(containsAbc
            ? "Документ содержит последовательность abc."
            : "Документ НЕ содержит последовательность abc.");

        bool startsWith555 = doc.StartsWith("555", StringComparison.Ordinal);
        Console.WriteLine(startsWith555
            ? "Документ начинается с 555."
            
            : "Документ НЕ начинается с 555.");
	}
}