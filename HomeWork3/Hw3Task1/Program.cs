namespace Hw3Task1;

class Program
{
    static void Main(string[] args)
    {
        double operand1 = 15;
        double operand2 = 3;

        Console.WriteLine($"Первое число: {operand1}");
        Console.WriteLine($"Второе число: {operand2}");
        Console.WriteLine();

        Console.WriteLine("Введите знак арифметической операции (+, -, *, /):");
        string sign = Console.ReadLine();

        double result = 0;

        switch (sign)
        {
            case "+":
                result = operand1 + operand2;
                Console.WriteLine($"\nОперация: сложение");
                break;

            case "-":
                result = operand1 - operand2;
                Console.WriteLine($"\nОперация: вычитание");
                break;

            case "*":
                result = operand1 * operand2;
                Console.WriteLine($"\nОперация: умножение");
                break;

            case "/":
                if (operand2 == 0)
                {
                    Console.WriteLine($"\nОшибка: деление на ноль невозможно!");
                }
                else
                {
                    result = operand1 / operand2;
                    Console.WriteLine($"\nОперация: деление");
                }
                break;

            default:
                Console.WriteLine($"\nОшибка: неизвестная операция '{sign}'");
                break;
        }

        Console.WriteLine($"{operand1} {sign} {operand2} = {result}");
    }
}