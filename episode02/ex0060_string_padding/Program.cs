public class Example
{
    public static void Main()
    {
        // Методы PadLeft и PadRight позволяют дополнить строку символами для достижения заданной длины.
        // Символы могут добавляться как слева (PadLeft), так и справа (PadRight).

        // Пример PadLeft
        string original = "Hello";
        string paddedLeft = original.PadLeft(10, '-');
        WriteLine($"Исходная строка: [{original}]");
        WriteLine($"После PadLeft: [{paddedLeft}]");

        // Пример PadRight
        string paddedRight = original.PadRight(10, '*');
        WriteLine($"После PadRight: [{paddedRight}]");

        // Пример с пробелами
        string paddedLeftSpaces = original.PadLeft(15);
        string paddedRightSpaces = original.PadRight(15);
        WriteLine($"После PadLeft с пробелами: [{paddedLeftSpaces}]");
        WriteLine($"После PadRight с пробелами: [{paddedRightSpaces}]");

        // Пример строки с длиной больше заданной
        string longString = "LongString";
        WriteLine($"Исходная строка: [{longString}]");
        WriteLine($"После PadLeft (без изменений): [{longString.PadLeft(5)}]");
        WriteLine($"После PadRight (без изменений): [{longString.PadRight(5)}]");

        // Пример с числовыми значениями для форматирования
        string number = "42";
        WriteLine($"Число без изменений: [{number}]");
        WriteLine($"После PadLeft для выравнивания: [{number.PadLeft(5, '0')}]");
        WriteLine($"После PadRight для выравнивания: [{number.PadRight(5, '0')}]");

        // Основная демонстрационная программа
        string title = "C# Padding";
        WriteLine($"Исходная строка: [{title}]");

        string paddedTitleLeft = title.PadLeft(20, '-');
        WriteLine($"После PadLeft с '-': [{paddedTitleLeft}]");

        string paddedTitleRight = title.PadRight(20, '=');
        WriteLine($"После PadRight с '=': [{paddedTitleRight}]");

        // Пример комбинированного использования PadLeft и PadRight
        string centeredTitle = title.PadLeft(15).PadRight(20, ' ');
        WriteLine($"Центрированная строка: [{centeredTitle}]");
    }
}
