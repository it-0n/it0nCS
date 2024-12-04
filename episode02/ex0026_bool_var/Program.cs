class Program
{
    static void Main()
    {
        // Объявление переменных типа bool
        bool isTrue = true;  // Переменная со значением true
        bool isFalse = false; // Переменная со значением false

        // Логические операции
        bool andResult = isTrue && isFalse; // Логическое И
        bool orResult = isTrue || isFalse;  // Логическое ИЛИ
        bool notResult = !isTrue;           // Логическое НЕ

        // Вывод значений
        WriteLine($"isTrue: {isTrue}");
        WriteLine($"isFalse: {isFalse}");
        WriteLine($"isTrue AND isFalse: {andResult}");
        WriteLine($"isTrue OR isFalse: {orResult}");
        WriteLine($"NOT isTrue: {notResult}");

        // Использование в условии
        if (isTrue)
        {
            WriteLine("isTrue равно true.");
        }

        if (!isFalse)
        {
            WriteLine("isFalse равно false.");
        }
    }
}
