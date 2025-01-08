using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // === Методы разделения строк ===

        // 1. String.Split
        WriteLine("Метод String.Split:");
        string sentence = "яблоко, груша, банан, ананас";
        string[] fruits = sentence.Split(','); // Разделяем строку по запятым
        foreach (string fruit in fruits)
        {
            WriteLine(fruit.Trim()); // Trim удаляет лишние пробелы
        }
        WriteLine();

        // 2. String.Substring
        WriteLine("Метод String.Substring:");
        string word = "Программирование";
        string part = word.Substring(0, 7); // Извлекаем первые 7 символов
        WriteLine(part); // Вывод: Програм
        WriteLine();

        // 3. String.IndexOf
        WriteLine("Метод String.IndexOf:");
        string text = "Hello, World!";
        int index = text.IndexOf("World"); // Ищем подстроку "World"
        WriteLine(index); // Вывод: 7
        WriteLine();

        // 4. String.IndexOfAny
        WriteLine("Метод String.IndexOfAny:");
        char[] charsToFind = { 'a', 'e', 'i', 'o', 'u' }; // Гласные буквы
        int vowelIndex = text.IndexOfAny(charsToFind);
        WriteLine(vowelIndex); // Вывод: 1 (буква 'e')
        WriteLine();

        // 5. String.LastIndexOf
        WriteLine("Метод String.LastIndexOf:");
        string path = "/user/local/bin/file";
        int lastSlash = path.LastIndexOf("/"); // Последний индекс символа "/"
        WriteLine(lastSlash); // Вывод: 15
        WriteLine();

        // 6. String.LastIndexOfAny
        WriteLine("Метод String.LastIndexOfAny:");
        char[] specialChars = { '/', '-' };
        int lastSpecialChar = path.LastIndexOfAny(specialChars);
        WriteLine(lastSpecialChar); // Вывод: 15 (символ '/')
        WriteLine();

        // === Регулярные выражения ===

        WriteLine("Примеры использования регулярных выражений");
        WriteLine("\nПример 1: Разбор арифметических выражений");
        string[] expressions = { "16 + 21", "31 * 3", "28 / 3", "42 - 18", "12 * 7" };
        string pattern = @"(\d+)\s+([-+*/])\s+(\d+)";

        foreach (string expression in expressions)
        {
            Match match = Regex.Match(expression, pattern);

            if (match.Success)
            {
                int operand1 = int.Parse(match.Groups[1].Value);
                string operation = match.Groups[2].Value;
                int operand2 = int.Parse(match.Groups[3].Value);

                // Вычисляем результат в зависимости от операции
                double result = operation switch
                {
                    "+" => operand1 + operand2,
                    "-" => operand1 - operand2,
                    "*" => operand1 * operand2,
                    "/" => Math.Round((double)operand1 / operand2, 2), // Округляем до двух знаков
                    _ => throw new InvalidOperationException("Неизвестная операция")
                };

                WriteLine($"{expression} = {result}");
            }
        }
        WriteLine();

        WriteLine("Пример 2: Поиск текста в квадратных скобках");
        string input2 = "[Ищем текст\n   в квадратных скобках.]\n\n[Это тоже текст в квадратных скобках.]\n[Ещё текст:\n\tОпция 1\n\tОпция 2][Просто текст.]";
        string pattern2 = @"\[([^\[\]]+)\]";
        int counter = 0;

        foreach (Match m in Regex.Matches(input2, pattern2))
        {
            WriteLine("{0}: {1}", ++counter, m.Groups[1].Value);
        }
        WriteLine();

        WriteLine("Пример 3: Разделение строки с использованием шаблона");
        string input3 = "abacus -- alabaster - * - atrium -+- any -*- actual - + - armoire - - alarm";
        string pattern3 = @"\s-\s?[+*]?\s?-\s";
        string[] elements = Regex.Split(input3, pattern3);

        foreach (string element in elements)
        {
            WriteLine(element);
        }
        WriteLine();

        WriteLine("Пример 4: Номера телефонов");

        string input4 = "Контакты: +1-123-456-7890, +44 20 7946 0958, +91-9876543210";
        string pattern4 = @"\+\d{1,3}([-.\s]?\d+)+";

        foreach (Match m in Regex.Matches(input4, pattern4))
        {
            WriteLine("Найден номер: {0}", m.Value);
        }
        WriteLine();

        WriteLine("Пример 5: Валидация email");
        string input5 = "emails: test@example.com, invalid-email, user.name@domain.co";
        string pattern5 = @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}";

        foreach (Match m in Regex.Matches(input5, pattern5))
        {
            WriteLine("Найден email: {0}", m.Value);
        }
        WriteLine();

        WriteLine("Пример 6: Валидация IPv4-адресов");

        // IPv4-адреса для проверки
        string[] ipAddresses = {
            "192.168.1.1",    // корректный
            "255.255.255.255", // корректный
            "256.300.1.1"     // некорректный
        };

        // Паттерн для валидации IPv4-адресов
        string ipv4Pattern = @"^(25[0-5]|2[0-4][0-9]|[0-1]?[0-9][0-9]?)\."
                            + @"(25[0-5]|2[0-4][0-9]|[0-1]?[0-9][0-9]?)\."
                            + @"(25[0-5]|2[0-4][0-9]|[0-1]?[0-9][0-9]?)\."
                            + @"(25[0-5]|2[0-4][0-9]|[0-1]?[0-9][0-9]?)$";

        // Проверка и вывод только корректных адресов
        foreach (string ip in ipAddresses)
        {
            if (Regex.IsMatch(ip, ipv4Pattern))
            {
                WriteLine($"Корректный IP-адрес: {ip}");
            }
            else
            {
                WriteLine($"Некорректный IP-адрес: {ip}");
            }
        }
    }
}
