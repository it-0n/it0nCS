class Program
{
    static char defaultChar; // Значение по умолчанию для char

    static void Main()
    {
        // Создание переменных типа char
        char letter = 'A';         // Символ 'A'
        char digit = '1';          // Символ '1'
        char symbol = '#';         // Символ '#'
        char newline = '\n';       // Символ новой строки
        char unicodeChar = '\u2764'; // Символ Unicode (❤)

        // Вывод значений переменных
        WriteLine($"Символ: {letter}, Unicode-код: {(int)letter}");
        WriteLine($"Символ: {digit}, Unicode-код: {(int)digit}");
        WriteLine($"Символ: {symbol}, Unicode-код: {(int)symbol}");
        WriteLine($"Символ новой строки: {newline}(переход на новую строку)");
        WriteLine($"Символ Unicode: {unicodeChar}, Unicode-код: {(int)unicodeChar}");

        // Операции с char
        char nextLetter = (char)(letter + 1); // Следующий символ в алфавите
        WriteLine($"Следующий символ после {letter}: {nextLetter}");

        // Проверка типов символов
        WriteLine($"'{letter}' - это буква: {char.IsLetter(letter)}");
        WriteLine($"'{digit}' - это цифра: {char.IsDigit(digit)}");
        WriteLine($"'{symbol}' - это буква или цифра: {char.IsLetterOrDigit(symbol)}");

        // Значение по умолчанию для char
        WriteLine($"\nЗначение по умолчанию типа char: '{defaultChar}'");
        WriteLine($"Код значения по умолчанию: {(int)defaultChar}");
        WriteLine($"Является ли значение по умолчанию нулевым символом ('\\0'): {defaultChar == '\0'}");

        // Диапазон значений char
        WriteLine($"\nМинимальное значение: '\\u{(int)char.MinValue:X4}'");
        WriteLine($"Максимальное значение: '\\u{(int)char.MaxValue:X4}'");
    }
}
