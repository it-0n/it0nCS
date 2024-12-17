class Program
{
    static void Main()
    {
        // Создаем nullable value types
        int? nullableInt1 = 42;
        int? nullableInt2 = null;

        // Пример: свойства HasValue и Value
        WriteLine($"nullableInt1.HasValue: {nullableInt1.HasValue}"); // True
        WriteLine($"nullableInt2.HasValue: {nullableInt2.HasValue}"); // False
        WriteLine($"nullableInt1.Value: {nullableInt1.Value}"); // 42

        // Оператор ?? (null-coalescing)
        int defaultValue = nullableInt2 ?? -1; // -1, так как nullableInt2 == null
        WriteLine($"nullableInt2 ?? -1: {defaultValue}");

        // Арифметические операции
        int? sum = nullableInt1 + nullableInt2; // null
        WriteLine($"Sum: {sum ?? 0}"); // Если sum == null, выводим 0

        int? multiply = nullableInt1 * 2; // 42 * 2 = 84
        WriteLine($"Multiply: {multiply}");

        // Операции сравнения
        WriteLine($"nullableInt1 > nullableInt2: {nullableInt1 > nullableInt2}"); // False
        WriteLine($"nullableInt2 < nullableInt1: {nullableInt2 < nullableInt1}"); // False
        WriteLine($"nullableInt1 == nullableInt2: {nullableInt1 == nullableInt2}"); // False
        WriteLine($"nullableInt2 != nullableInt1: {nullableInt2 != nullableInt1}"); // True

        // Преобразование типов
        int normalInt = nullableInt1.GetValueOrDefault(); // 42
        WriteLine($"Converted Value: {normalInt}");

        // Пример с null-значениями в арифметике
        nullableInt1 = null;
        nullableInt2 = 10;
        int? result = nullableInt1 + nullableInt2; // null
        WriteLine($"Result of nullableInt1 + nullableInt2: {result ?? 0}");
    }
}