class Program
{
    static void Main()
    {
        int a = 5, b = 10;
        bool x = true, y = false;

        WriteLine("=== Операции сравнения ===");
        WriteLine($"a == b: {a == b}");  // false
        WriteLine($"a != b: {a != b}");  // true
        WriteLine($"a > b: {a > b}");    // false
        WriteLine($"a < b: {a < b}");    // true
        WriteLine($"a >= b: {a >= b}");  // false
        WriteLine($"a <= b: {a <= b}");  // true

        WriteLine("\n=== Логические операции ===");
        WriteLine($"x || y: {x || y}");  // true (y не вычисляется)
        WriteLine($"x | y: {x | y}");    // true (оба вычисляются)

        WriteLine($"x && y: {x && y}");  // false (y не вычисляется)
        WriteLine($"x & y: {x & y}");    // false (оба вычисляются)

        WriteLine($"!x: {!x}");          // false (отрицание)
        WriteLine($"x ^ y: {x ^ y}");    // true (разные значения)

        WriteLine("\n=== Проверка разницы между && и & ===");
        WriteLine("false && ExpensiveFunction():");
        bool result1 = false && ExpensiveFunction(); // ExpensiveFunction() НЕ вызывается
        Write("false & ExpensiveFunction(): ");
        bool result2 = false & ExpensiveFunction();  // ExpensiveFunction() вызывается

        WriteLine("\n=== Проверка разницы между || и | ===");
        WriteLine("true || ExpensiveFunction():");
        bool result3 = true || ExpensiveFunction();  // ExpensiveFunction() НЕ вызывается
        Write("true | ExpensiveFunction(): ");
        bool result4 = true | ExpensiveFunction();   // ExpensiveFunction() вызывается
    }

    static bool ExpensiveFunction()
    {
        WriteLine("ДОЛГАЯ ФУНКЦИЯ вызвана!");
        return true;
    }
}