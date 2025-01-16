using System;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        WriteLine("=== Демонстрация StringBuilder ===\n");

        // Создание StringBuilder
        StringBuilder sb = new StringBuilder("Привет, мир!");
        WriteLine($"Исходная строка: {sb}\n");

        // Настройка емкости и длины
        sb.Capacity = 50;  // Устанавливаем емкость
        WriteLine($"Емкость после установки: {sb.Capacity}");
        sb.Length = 6;  // Уменьшаем длину строки
        WriteLine($"После обрезки длины: {sb}\n");

        // Изменение строки (методы StringBuilder)
        sb.Append("! Как дела?");
        WriteLine($"Append: {sb}");

        sb.AppendFormat(" Сегодня {0}.", DateTime.Now.DayOfWeek);
        WriteLine($"AppendFormat: {sb}");

        sb.Insert(7, " Дорогой!");
        WriteLine($"Insert: {sb}");

        sb.Remove(6, 9);
        WriteLine($"Remove: {sb}");

        sb.Replace("!", "! Друзья!");
        WriteLine($"Replace: {sb}\n");

        // Преобразование StringBuilder в строку
        string result = sb.ToString();
        WriteLine($"Преобразованный в string: {result}\n");

        // Поиск текста в StringBuilder (четыре метода)

        // 1. Поиск перед добавлением
        string textToFind = "Привет";
        if (!sb.ToString().Contains(textToFind))
        {
            sb.Append(" Привет");
        }
        WriteLine($"Поиск перед добавлением: {sb}");

        // 2. Преобразование в строку и поиск IndexOf
        int index = sb.ToString().IndexOf("Сегодня");
        WriteLine($"IndexOf поиска 'Сегодня': {index}");

        // 3. Поиск через Chars[] (исправленный)
        bool found = false;
        string searchString = "Друзья";
        for (int i = 0; i <= sb.Length - searchString.Length; i++)
        {
            bool match = true;
            for (int j = 0; j < searchString.Length; j++)
            {
                if (sb[i + j] != searchString[j])
                {
                    match = false;
                    break;
                }
            }
            if (match)
            {
                found = true;
                break;
            }
        }
        WriteLine($"Поиск через Chars[]: {(found ? "Найдено" : "Не найдено")}");

        // 4. Преобразование StringBuilder в string, поиск и модификация
        string tempString = sb.ToString();
        if (tempString.Contains("Друзья"))
        {
            tempString = tempString.Replace("Друзья", "Товарищи");
            sb.Clear().Append(tempString);
        }
        WriteLine($"Изменение через строку: {sb}");

        // Дополнительно: Поиск через регулярные выражения (бонус)
        bool regexFound = Regex.IsMatch(sb.ToString(), @"\bТоварищи\b");
        WriteLine($"Поиск через RegEx: {(regexFound ? "Найдено" : "Не найдено")}");
    }
}
