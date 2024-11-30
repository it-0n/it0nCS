namespace IntegerLiteralsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Десятичный литерал
            int decimalLiteral = 42;
            WriteLine($"Десятичный: {decimalLiteral}");

            // Шестнадцатеричный литерал
            int hexLiteral = 0x2A;
            WriteLine($"Шестнадцатеричный: {hexLiteral}");

            // Двоичный литерал
            int binaryLiteral = 0b101010;
            WriteLine($"Двоичный: {binaryLiteral}");

            // Литералы с суффиксами
            long longLiteral = 42L;
            uint uintLiteral = 42U;
            ulong ulongLiteral = 42UL;

            WriteLine($"Суффиксы:");
            WriteLine($"  long: {longLiteral}");
            WriteLine($"  uint: {uintLiteral}");
            WriteLine($"  ulong: {ulongLiteral}");

            // Литералы с разделителями цифр
            int largeNumber = 1_000_000;
            int binaryWithSeparators = 0b1010_1010_1111_0000;

            WriteLine($"С разделителями цифр:");
            WriteLine($"  Большое число: {largeNumber}");
            WriteLine($"  Двоичный: {binaryWithSeparators}");
        }
    }
}
