using System;

class Program
{
    static void Main()
    {
        // Литералы типа char
        char letter = 'A';                  // Обычный символ
        char digit = '5';                   // Цифра
        char symbol = '#';                  // Специальный символ
        char newline = '\n';                // Символ новой строки
        char tab = '\t';                    // Табуляция
        char singleQuote = '\'';            // Одиночная кавычка
        char unicodeHeart = '\u2764';       // Красное сердце
        char unicodeOm = '\u0950';          // Символ Ом ॐ
        char unicodeSmiley = '\u263A';      // Улыбающийся смайлик

        // Вывод значений литералов
        WriteLine($"Обычный символ: {letter}");
        WriteLine($"Цифра: {digit}");
        WriteLine($"Специальный символ: {symbol}");
        WriteLine($"Табуляция: {tab}(после табуляции)");
        WriteLine($"Одиночная кавычка: {singleQuote}");
        WriteLine($"Символ новой строки:{newline}Новая строка начинается здесь");

        // Цветной вывод
        ForegroundColor = ConsoleColor.Red;
        WriteLine($"Красное сердце: {unicodeHeart}");

        ForegroundColor = ConsoleColor.DarkYellow;
        WriteLine($"Улыбающийся смайлик: {unicodeSmiley}");

        ForegroundColor = ConsoleColor.DarkMagenta;
        WriteLine($"Символ Омкары: {unicodeOm}");

        // Сброс цвета консоли
        ResetColor();
    }
}
