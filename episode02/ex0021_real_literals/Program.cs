class Program
{
    static void Main()
    {
        WriteLine("Демонстрация вещественных литералов:");

        // float литералы
        float floatLiteral1 = 3.14f;
        float floatLiteral2 = -0.1f;
        float floatLiteral3 = 1.5e2f; // Экспоненциальная форма

        WriteLine($"floatLiteral1: {floatLiteral1}");
        WriteLine($"floatLiteral2: {floatLiteral2}");
        WriteLine($"floatLiteral3: {floatLiteral3}");

        // double литералы (по умолчанию)
        double doubleLiteral1 = 3.14;
        double doubleLiteral2 = -0.1;
        double doubleLiteral3 = 1.5e10; // Экспоненциальная форма

        WriteLine($"\ndoubleLiteral1: {doubleLiteral1}");
        WriteLine($"doubleLiteral2: {doubleLiteral2}");
        WriteLine($"doubleLiteral3: {doubleLiteral3}");

        // decimal литералы
        decimal decimalLiteral1 = 3.14m;
        decimal decimalLiteral2 = -0.1m;
        decimal decimalLiteral3 = 1.5e2m; // Экспоненциальная форма запрещена

        WriteLine($"\ndecimalLiteral1: {decimalLiteral1}");
        WriteLine($"decimalLiteral2: {decimalLiteral2}");
        WriteLine($"decimalLiteral3: {decimalLiteral3}");

        // Сравнение float и double
        float floatComparison = 0.1f + 0.2f;
        double doubleComparison = 0.1 + 0.2;

        WriteLine($"\nСравнение float и double:");
        WriteLine($"float (0.1f + 0.2f): {floatComparison:F20}");
        WriteLine($"double (0.1 + 0.2): {doubleComparison:F20}");
    }
}