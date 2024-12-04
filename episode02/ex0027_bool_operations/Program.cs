class Program
{
    static void Main()
    {
        // Исходные значения
        bool a = true;
        bool b = false;

        // Логические операции
        WriteLine("Логические операции:");
        WriteLine($"!a = {!a}");                      // Логическое НЕ
        WriteLine($"a && b = {a && b}");              // Логическое И
        WriteLine($"a || b = {a || b}");              // Логическое ИЛИ
        WriteLine($"a ^ b = {a ^ b}");                // Исключающее ИЛИ

        // Операции сравнения
        WriteLine("\nОперации сравнения:");
        WriteLine($"a == b = {a == b}");              // Проверка на равенство
        WriteLine($"a != b = {a != b}");              // Проверка на неравенство

        // Присваивание
        WriteLine("\nОперации присваивания:");
        bool c = a;                                           // Присваивание
        WriteLine($"c = {c}");

        // Комбинация операций
        WriteLine("\nКомбинированные выражения:");
        bool result = (a || b) && !b;                        // Смешанные операции
        WriteLine($"(a || b) && !b = {result}");
    }
}
