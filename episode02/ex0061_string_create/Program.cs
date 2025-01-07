using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // 1. Создание строки через литералы
        string literalString = "Привет, мир!";
        WriteLine("Литерал строки: " + literalString);

        // 2. Создание строки из массива символов
        char[] chars = { 'П', 'р', 'и', 'в', 'е', 'т' };
        string charArrayString = new string(chars);
        WriteLine("Строка из массива символов: " + charArrayString);

        // 3. Использование String.Concat
        string concatString = String.Concat("Привет", ", ", "мир", "!");
        WriteLine("String.Concat: " + concatString);

        // 4. Использование String.Join
        string[] words = { "Привет", "мир" };
        string joinString = String.Join(", ", words);
        WriteLine("String.Join: " + joinString);

        // 5. Использование String.Insert
        string insertString = "Привет мир";
        insertString = insertString.Insert(6, ",");
        WriteLine("String.Insert: " + insertString);

        // 6. Использование String.CopyTo
        string copyString = "Привет";
        char[] destination = new char[7];
        copyString.CopyTo(0, destination, 0, copyString.Length);
        WriteLine("String.CopyTo: " + new string(destination));

        // 7. Использование оператора +
        string plusString = "Привет" + ", " + "мир" + "!";
        WriteLine("Оператор +: " + plusString);

        // 8. Использование StringBuilder
        StringBuilder sb = new StringBuilder();
        sb.Append("Привет");
        sb.Append(", ");
        sb.Append("мир");
        sb.Append("!");
        string stringBuilderString = sb.ToString();
        WriteLine("StringBuilder: " + stringBuilderString);
    }
}
