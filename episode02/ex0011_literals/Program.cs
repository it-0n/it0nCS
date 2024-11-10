class Program
{
    static void Main()
    {
        // Целочисленные литералы
        int decimalLiteral = 10;           // Десятичный литерал
        int hexLiteral = 0x1A;             // Шестнадцатеричный литерал
        int binaryLiteral = 0b1010;        // Бинарный литерал

        // Вещественные литералы
        double doubleLiteral = 3.14;       // Десятичное значение
        float floatLiteral = 2.71F;        // С суффиксом 'F' для типа float

        // Символьные литералы
        char charLiteral = 'A';            // Символ в одинарных кавычках

        // Строковые литералы
        string stringLiteral = "Hello, C#!"; // Строка в двойных кавычках

        // Логические литералы
        bool trueLiteral = true;           // Логическое значение true
        bool falseLiteral = false;         // Логическое значение false

        // Null-литерал
        object nullLiteral = null;         // Значение null

        // Вывод всех литералов
        Console.WriteLine($"Целочисленные литералы: {decimalLiteral}, {hexLiteral}, {binaryLiteral}");
        Console.WriteLine($"Вещественные литералы: {doubleLiteral}, {floatLiteral}");
        Console.WriteLine($"Символьный литерал: {charLiteral}");
        Console.WriteLine($"Строковый литерал: {stringLiteral}");
        Console.WriteLine($"Логические литералы: {trueLiteral}, {falseLiteral}");
        Console.WriteLine($"Null-литерал: {nullLiteral}");
    }
}
