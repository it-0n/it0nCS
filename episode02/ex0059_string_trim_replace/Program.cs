public class Example
{
    public static void Main()
    {
        // Пример Trim
        string myString = "   Hello World!   ";
        WriteLine($"Исходная строка: [{myString}]");
        string trimmedString = myString.Trim();
        WriteLine($"После Trim: [{trimmedString}]");

        string header = "**...Welcome!...**";
        char[] trimChars = { '*', '.', '!' };
        WriteLine($"Исходная строка: [{header}]");
        WriteLine($"После Trim с символами: [{header.Trim(trimChars)}]");

        // Пример TrimStart
        string myStringStart = "!!!Hello World!!!";
        char[] trimStartChars = { '!', 'H' };
        WriteLine($"Исходная строка: [{myStringStart}]");
        WriteLine($"После TrimStart: [{myStringStart.TrimStart(trimStartChars)}]");

        // Пример TrimEnd
        string myStringEnd = "Hello World!!!";
        char[] trimEndChars = { '!', 'd' };
        WriteLine($"Исходная строка: [{myStringEnd}]");
        WriteLine($"После TrimEnd: [{myStringEnd.TrimEnd(trimEndChars)}]");

        // Пример Remove
        string myStringRemove = "Hello Beautiful World!";
        WriteLine($"Исходная строка: [{myStringRemove}]");
        WriteLine($"После Remove(6, 10): [{myStringRemove.Remove(6, 10)}]");
        WriteLine($"После Remove(5): [{myStringRemove.Remove(5)}]");

        // Пример Replace
        string phrase = "a cold, dark night";
        WriteLine($"Исходная строка: [{phrase}]");
        WriteLine($"После Replace: [{phrase.Replace(",", "")}]");

        // Основная программа
        string text = "=== Hello, World! ===";

        WriteLine($"Исходная строка: [{text}]");

        // Удаление начальных и конечных символов
        string trimmedText = text.Trim('=');
        WriteLine($"После Trim: [{trimmedText}]");

        // Удаление начальных символов
        string trimmedStart = text.TrimStart('=');
        WriteLine($"После TrimStart: [{trimmedStart}]");

        // Удаление конечных символов
        string trimmedEnd = text.TrimEnd('=');
        WriteLine($"После TrimEnd: [{trimmedEnd}]");

        // Удаление части строки
        string removedText = text.Remove(4, 12); // Удаляем " Hello, World"
        WriteLine($"После Remove: [{removedText}]");

        // Замена символов
        string replacedText = text.Replace("=", "");
        WriteLine($"После Replace: [{replacedText}]");
    }
}
