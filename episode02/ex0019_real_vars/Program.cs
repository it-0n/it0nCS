class Program
{
    // Значения по умолчанию для вещественных типов
    private static float defaultFloat;
    private static double defaultDouble;
    private static decimal defaultDecimal;

    static void Main(string[] args)
    {
        // Минимальные и максимальные значения для вещественных типов
        float minFloat = float.MinValue;
        float maxFloat = float.MaxValue;

        double minDouble = double.MinValue;
        double maxDouble = double.MaxValue;

        decimal minDecimal = decimal.MinValue;
        decimal maxDecimal = decimal.MaxValue;

        // Вывод значений
        WriteLine("Тип: float");
        WriteLine($"Значение по умолчанию: {defaultFloat}");
        WriteLine($"Минимальное значение: {minFloat}");
        WriteLine($"Максимальное значение: {maxFloat}");
        WriteLine();

        WriteLine("Тип: double");
        WriteLine($"Значение по умолчанию: {defaultDouble}");
        WriteLine($"Минимальное значение: {minDouble}");
        WriteLine($"Максимальное значение: {maxDouble}");
        WriteLine();

        WriteLine("Тип: decimal");
        WriteLine($"Значение по умолчанию: {defaultDecimal}");
        WriteLine($"Минимальное значение: {minDecimal}");
        WriteLine($"Максимальное значение: {maxDecimal}");
    }
}
