using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        // Работа с String.Replace
        WriteLine("=== String.Replace ===");
        
        // Replace(Char, Char)
        string text1 = "banana";
        WriteLine(text1.Replace('a', 'o')); // Замена символа 'a' на 'o'

        // Replace(String, String)
        string text2 = "I love cats.";
        WriteLine(text2.Replace("cats", "dogs")); // Замена слова "cats" на "dogs"

        // Replace(String, String, StringComparison)
        string text3 = "Good Morning!";
        WriteLine(text3.Replace("morning", "evening", StringComparison.OrdinalIgnoreCase)); // Игнорируем регистр

        // Replace(String, String, Boolean, CultureInfo)
        string text4 = "Straße";
        WriteLine(text4.Replace("ß", "ss", false, new CultureInfo("de-DE"))); // Учитываем немецкий язык и регистр

        // Работа с String.ReplaceLineEndings
        WriteLine("\n=== String.ReplaceLineEndings ===");

        // ReplaceLineEndings()
        string multilineText1 = "Hello\nWorld!\r\nHow are you?\r";
        WriteLine(multilineText1.ReplaceLineEndings()); // Заменяем на символ перевода строки ОС

        // ReplaceLineEndings(String)
        string multilineText2 = "Line1\nLine2\r\nLine3\r";
        WriteLine(multilineText2.ReplaceLineEndings("---")); // Заменяем символы перевода строки на "---"
    }
}