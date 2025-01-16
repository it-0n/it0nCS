using System;
using System.Text;
using System.Globalization;

class Program
{
    static void Main()
    {
        WriteLine("=== Демонстрация методов StringBuilder ===\n");

        // Устанавливаем текущую культуру системы для программы
        CultureInfo culture = CultureInfo.CurrentCulture;

        // Создаем StringBuilder
        StringBuilder sb = new StringBuilder("Привет");

        // Append
        sb.Append(", мир!"); // Добавляем строку
        sb.Append(' ');      // Добавляем символ пробела
        sb.Append("Сейчас "); // Добавляем строку
        sb.Append($"{DateTime.Now:MMMM} "); // Добавляем интеполированную строку
        sb.Append($"{DateTime.Now:yyyy}"); // Добавляем интеполированную строку
        sb.Append(" года и это ");      // Добавляем строку.
        sb.Append(true);     // Добавляем логическое значение
        sb.Append(' ');      // Добавляем символ пробела
        sb.Append(100); // Добавляем число
        sb.Append('%');      // Добавляем символ процента
        sb.Append('.');      // Добавляем символ точки
        WriteLine($"Append: {sb}");

        // AppendFormat (теперь с учетом культуры)
        sb.AppendFormat(culture, " Сегодня {0}, {1}. ", DateTime.Now.ToString("dddd", culture), "прекрасный день");
        WriteLine($"AppendFormat: {sb}");

        // AppendJoin
        string[] fruits = { "И", "мы", "едим", "яблоко,", "банан", "и", "вишню." };
        sb.AppendJoin(" ", fruits); // разделяет добавляемые слова пробелом
        WriteLine($"AppendJoin: {sb}");

        // AppendLine
        sb.AppendLine(); // добавление перехода на новую строку
        sb.AppendLine("Добавлена новая строка.");
        WriteLine($"AppendLine:\n{sb}");

        // CopyTo
        char[] buffer = new char[6];
        sb.CopyTo(0, buffer, 0, 6); // Копируем кусок строки в массив
        WriteLine($"CopyTo: {new string(buffer)}");

        // Insert
        sb.Insert(8, "прекрасный "); // Вставляем строку
        sb.Insert(sb.Length, '!'); // Вставляем символ в конец
        WriteLine($"Insert: {sb}");

        // Remove
        sb.Remove(7, 11); // Удаляем "Дорогой "
        WriteLine($"Remove: {sb}");

        // Replace
        sb.Replace("мир", "вселенная");
        sb.Replace('!', '*');
        WriteLine($"Replace: {sb}");

        // Equals
        StringBuilder sb2 = new StringBuilder(sb.ToString());
        WriteLine($"Equals (сравнение с копией): {sb.Equals(sb2)}");

        // Преобразование в строку
        string result = sb.ToString();
        WriteLine("\nПреобразованный в string: " + result);
    }
}
