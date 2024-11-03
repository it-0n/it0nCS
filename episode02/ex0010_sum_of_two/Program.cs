using System.Globalization;

namespace ex0010_sum_of_two;

class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");
        Console.Write("Введите первое число: ");
        var input1 = Console.ReadLine();

        Console.Write("Введите второе число: ");
        var input2 = Console.ReadLine();

        // Преобразуем строки в числа с учетом дробной части
        if (double.TryParse(input1, NumberStyles.Any, CultureInfo.InvariantCulture, out double number1) &&
            double.TryParse(input2, NumberStyles.Any, CultureInfo.InvariantCulture, out double number2))
        {
            double sum = number1 + number2;
            Console.WriteLine($"Сумма чисел: {sum}");
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите числа.");
        }

    }
}
