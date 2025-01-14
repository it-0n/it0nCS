using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        // 1. Парсинг с учётом культуры
        string usDate = "12/03/2025";
        var usCulture = new CultureInfo("en-US");
        DateTime parsedUsDate = DateTime.Parse(usDate, usCulture);
        WriteLine($"Дата (США): {parsedUsDate}");

        // 2. Использование ParseExact
        string exactDate = "2025-12-03 15:30:45";
        string exactFormat = "yyyy-MM-dd HH:mm:ss";
        DateTime parsedExact = DateTime.ParseExact(exactDate, exactFormat, CultureInfo.InvariantCulture);
        WriteLine($"Точная дата: {parsedExact}");

        // 3. Форматирование в строки
        string formattedDate = parsedExact.ToString("dd.MM.yyyy HH:mm");
        WriteLine($"Форматированная дата: {formattedDate}");

        // 4. Разные культуры
        string frenchDate = parsedExact.ToString("F", new CultureInfo("fr-FR"));
        WriteLine($"Дата на французском: {frenchDate}");

        // 5. С временной зоной (UTC)
        DateTime utcDate = DateTime.UtcNow;
        WriteLine($"Текущее время в UTC: {utcDate}");
    }
}