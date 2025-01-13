using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        string original = "hello world!";
        string turkishText = "Istanbul"; // Текст с латинской буквой "I"

        // Преобразование в верхний регистр с учетом культуры
        string upper = original.ToUpper();
        WriteLine("Верхний регистр: " + upper);

        // Преобразование в нижний регистр с учетом культуры
        string lower = upper.ToLower();
        WriteLine("Нижний регистр: " + lower);

        // Преобразование в верхний регистр без учета культуры
        string upperInvariant = original.ToUpperInvariant();
        WriteLine("ToUpperInvariant: " + upperInvariant);

        // Преобразование в нижний регистр без учета культуры
        string lowerInvariant = upper.ToLowerInvariant();
        WriteLine("ToLowerInvariant: " + lowerInvariant);

        // Преобразование в нижний регистр с текущей культурой (русской)
        string lowerCurrentCulture = turkishText.ToLower();
        WriteLine("ToLower (русская культура): " + lowerCurrentCulture);

        // Преобразование в нижний регистр с турецкой культурой
        CultureInfo turkishCulture = new CultureInfo("tr-TR");
        string lowerTurkishCulture = turkishText.ToLower(turkishCulture);
        WriteLine("ToLower (турецкая культура): " + lowerTurkishCulture);

        // Преобразование в нижний регистр без учета культуры (Invariant)
        lowerInvariant = turkishText.ToLowerInvariant();
        WriteLine("ToLowerInvariant: " + lowerInvariant);

        // Преобразование в верхний регистр
        string upperTurkishCulture = turkishText.ToUpper(turkishCulture);
        WriteLine("ToUpper (турецкая культура): " + upperTurkishCulture);

        // Преобразование каждого слова в заглавные буквы
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        string titleCase = textInfo.ToTitleCase(original);
        WriteLine("\nЗаглавные буквы каждого слова: " + titleCase);

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