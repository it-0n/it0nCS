using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string name = null;
        int? age = null;
        double? height = null;

        // Обработка аргументов командной строки
        if (args.Length >= 1)
            name = args[0];

        if (args.Length >= 2 && int.TryParse(args[1], out int parsedAge))
            age = parsedAge;

        if (args.Length >= 3 && TryParseHeight(args[2], out double parsedHeight))
            height = parsedHeight;

        // Запрос недостающих данных у пользователя
        if (string.IsNullOrWhiteSpace(name))
        {
            Write("Введите ваше имя: ");
            name = ReadLine();
        }

        while (age == null)
        {
            Write("Введите ваш возраст (целое число): ");
            string input = ReadLine();
            if (int.TryParse(input, out parsedAge))
                age = parsedAge;
            else
                WriteLine("Ошибка: Введите корректное целое число.");
        }

        while (height == null)
        {
            Write("Введите ваш рост (число с дробной частью): ");
            string input = ReadLine();
            if (TryParseHeight(input, out parsedHeight))
                height = parsedHeight;
            else
                WriteLine("Ошибка: Введите корректное число (разделитель - точка или запятая).");
        }

        // Вывод данных
        WriteLine("\nВы ввели:");
        WriteLine($"Имя: {name}");
        WriteLine($"Возраст: {age}");
        WriteLine($"Рост: {height:F2}");
    }

    // Метод для парсинга числа с дробной частью в независимости от культуры
    static bool TryParseHeight(string input, out double result)
    {
        return double.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out result) ||
            double.TryParse(input, NumberStyles.Float, new CultureInfo("ru-RU"), out result);
    }
}