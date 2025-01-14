using System;
using System.Globalization;
using System.Linq;

class Program
{
    static void Main()
    {
        WriteLine("=== Синтаксический анализ с форматами ===");
        string number = "1,234.56";

        var usCulture = new CultureInfo("en-US");
        double usNumber = double.Parse(number, usCulture);
        WriteLine($"US формат: {usNumber.ToString(usCulture)}");

        var germanCulture = new CultureInfo("de-DE");
        try
        {
            double germanNumber = double.Parse(number, germanCulture);
            WriteLine($"German формат: {germanNumber}");
        }
        catch (FormatException)
        {
            WriteLine("Упс! Германия не понимает такой формат числа!");
        }

        WriteLine("\n=== Числа с пробелами и валютой ===");
        string currencyNumber = " $  1,234.56 ";
        double parsedCurrency = double.Parse(currencyNumber, NumberStyles.Currency, usCulture);
        WriteLine($"Число: {parsedCurrency}");

        WriteLine("\n=== Числа в Юникоде ===");

        // Арабские цифры
        string arabicNumber = "١٢٣٤";
        string normalizedArabic = NormalizeUnicodeDigits(arabicNumber);
        int parsedArabic = int.Parse(normalizedArabic, NumberStyles.None, CultureInfo.InvariantCulture);
        WriteLine($"Арабские цифры: {parsedArabic}");

        // Деванагари цифры
        string devanagariNumber = "१२३४";
        string normalizedDevanagari = NormalizeUnicodeDigits(devanagariNumber);
        int parsedDevanagari = int.Parse(normalizedDevanagari, NumberStyles.None, CultureInfo.InvariantCulture);
        WriteLine($"Деванагари цифры: {parsedDevanagari}");
    }

    /// <summary>
    /// Преобразует Unicode-цифры в их эквиваленты в диапазоне '0-9'.
    /// </summary>
    static string NormalizeUnicodeDigits(string input)
    {
        return new string(input.Select(c => char.GetUnicodeCategory(c) == UnicodeCategory.DecimalDigitNumber 
            ? (char)('0' + CharUnicodeInfo.GetDigitValue(c)) 
            : c).ToArray());
    }
}
