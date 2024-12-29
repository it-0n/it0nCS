class VerbatimAndEscapeDemo
{
    static void Main()
    {
        // Обычная строка с escape-последовательностями
        string regularPath = "C:\\tvstock\\new2024\\";
        WriteLine($"Обычная строка: {regularPath}");

        // Дословная строка
        string verbatimPath = @"C:\tvstock\new2024\";
        WriteLine($"Дословная строка: {verbatimPath}");

        // Строка с кавычками
        string regularQuote = "Она сказала: \"Привет!\"";
        WriteLine($"Обычная строка с кавычками: {regularQuote}");

        string verbatimQuote = @"Она сказала: ""Привет!""";
        WriteLine($"Дословная строка с кавычками: {verbatimQuote}");

        // Многострочная строка
        string multiline = @"Это первая строка.
Это вторая строка.
Это третья строка.";
        WriteLine("Многострочная строка:");
        WriteLine(multiline);

        // Различия в интерпретации символов
        string escapeSequence = "Строка с табуляцией:\tи переводом строки.\nКонец строки.";
        WriteLine("Обычная строка с escape-последовательностями:");
        WriteLine(escapeSequence);

        string verbatimLiteral = @"Строка с табуляцией:\tи переводом строки.\nКонец строки.";
        WriteLine("Дословная строка (символы интерпретируются буквально):");
        WriteLine(verbatimLiteral);
    }
}