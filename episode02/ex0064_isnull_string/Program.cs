using System;

class Program
{
    static void Main()
    {
        string[] testStrings = {
            null,          // Null строка
            "",            // Пустая строка
            "   ",         // Строка из пробелов
            "\t\n",        // Строка из табуляции и переноса строки
            "Hello World", // Обычная строка
        };

        foreach (var str in testStrings)
        {
            WriteLine($"Строка: \"{str}\"");
            WriteLine($"IsNullOrEmpty: {String.IsNullOrEmpty(str)}");
            WriteLine($"IsNullOrWhiteSpace: {String.IsNullOrWhiteSpace(str)}");
            WriteLine();
        }
    }
}