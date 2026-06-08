using System.Text;

namespace Hw5Task4;

class Program
{
    static void Main(string[] args)
	{
        // Пример ввода: 1234-abc-5678-def-1a2b
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

        // 1) Два первых блока по 4 цифры
        Console.WriteLine($"Первые два цифровых блока: {parts[0]} {parts[2]}");

        // 2) Номер документа, где блоки из трех букв заменены на ***
        string masked = $"{parts[0]}-***-{parts[2]}-***-{parts[4]}";
        Console.WriteLine($"Замаскированный документ: {masked}");

        // 3) Только буквы в формате yyy/yyy/y/y в нижнем регистре
        string lettersLower = $"{parts[1]}/{parts[3]}/{parts[4][1]}/{parts[4][3]}".ToLower();
        Console.WriteLine($"Буквы (lower): {lettersLower}");

        // 4) Letters:yyy/yyy/y/y в верхнем регистре (через StringBuilder)
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

        // 5) Содержит ли "abc" без учета регистра
        bool containsAbc = doc.IndexOf("abc", StringComparison.OrdinalIgnoreCase) >= 0;
        Console.WriteLine(containsAbc
            ? "Документ содержит последовательность abc."
            : "Документ НЕ содержит последовательность abc.");

        // 6) Начинается ли с 555
        bool startsWith555 = doc.StartsWith("555", StringComparison.Ordinal);
        Console.WriteLine(startsWith555
            ? "Документ начинается с 555."
            
            : "Документ НЕ начинается с 555.");
	}
}