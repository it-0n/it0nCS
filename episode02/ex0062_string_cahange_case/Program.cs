using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        string original = "hello world!";

        // Преобразование в верхний регистр
        string upper = original.ToUpper();
        WriteLine("Верхний регистр: " + upper);

        // Преобразование в нижний регистр
        string lower = upper.ToLower();
        WriteLine("Нижний регистр: " + lower);

        // Преобразование в заглавные буквы каждого слова
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        string titleCase = textInfo.ToTitleCase(original);
        WriteLine("Заглавные буквы каждого слова: " + titleCase);

        // Преобразование первого символа строки в верхний регистр
        if (original.Length > 0)
        {
            char firstChar = original[0];
            char upperFirstChar = Char.ToUpper(firstChar);
            string result = upperFirstChar + original.Substring(1);
            WriteLine("Первый символ в верхнем регистре: " + result);
        }
    }
}