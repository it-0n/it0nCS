using System.Globalization;

class SpecialRealNumberValuesDemo
{
    static void Main()
    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        const int col1 = 37; // Ширина первой колонки.
        const int col2 = 6;  // Ширина второй колонки.
        string line = new string('-', col1 + col2 + 6);

        WriteLine("Специальные значения для double:");
        WriteLine($"double.Epsilon: {double.Epsilon}");
        WriteLine($"double.Epsilon до 324 знаков после запятой: {double.Epsilon:N324}");
        WriteLine(line);
        WriteLine($"{"Выражение",-col1} | {"Значение",col2}");
        WriteLine(line);
        WriteLine($"{"double.NaN",-col1} | {double.NaN,col2}");
        WriteLine($"{"double.PositiveInfinity",-col1} | {double.PositiveInfinity,col2}");
        WriteLine($"{"double.NegativeInfinity",-col1} | {double.NegativeInfinity,col2}");
        WriteLine(line);
        WriteLine($"{" 0.0 / 0.0",-col1} | {0.0 / 0.0,col2}");
        WriteLine($"{" 3.0 / 0.0",-col1} | {3.0 / 0.0,col2}");
        WriteLine($"{"-3.0 / 0.0",-col1} | {-3.0 / 0.0,col2}");
        WriteLine(line);

        WriteLine("\nСпециальные значения для float:");
        WriteLine($"float.Epsilon: {float.Epsilon}");
        WriteLine($"float.Epsilon до 50 знаков после запятой: {float.Epsilon:N50}");
        WriteLine(line);
        WriteLine($"{"Выражение",-col1} | {"Значение",col2}");
        WriteLine(line);
        WriteLine($"{"float.NaN",-col1} | {float.NaN,col2}");
        WriteLine($"{"float.PositiveInfinity",-col1} | {float.PositiveInfinity,col2}");
        WriteLine($"{"float.NegativeInfinity",-col1} | {float.NegativeInfinity,col2}");
        WriteLine(line);
        WriteLine($"{" 0f / 0f",-col1} | {0f / 0f,col2}");
        WriteLine($"{" 3f / 0f",-col1} | {3f / 0f,col2}");
        WriteLine($"{"-3f / 0f",-col1} | {-3f / 0f,col2}");
        WriteLine(line);

        // Проверка на Infinity и NaN
        WriteLine("\nПроверки специальных значений:");
        WriteLine($"{"float.IsNaN(0f / 0f)",-col1} | {float.IsNaN(0f / 0f),col2}");
        WriteLine($"{"float.IsInfinity(3f / 0f)",-col1} | {float.IsInfinity(3f / 0f),col2}");
        WriteLine($"{"double.IsNaN(0.0 / 0.0)",-col1} | {double.IsNaN(0.0 / 0.0),col2}");
        WriteLine($"{"double.IsInfinity(3.0 / 0.0)",-col1} | {double.IsInfinity(3.0 / 0.0),col2}");
        WriteLine(line);
    }
}
