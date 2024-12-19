class Program
{
    // Константы для значимых типов
    const int MAX_AGE = 120;
    const double PI = 3.14159;
    const bool IS_HUMAN = true;

    // Константы для ссылочных типов
    const string DEFAULT_MESSAGE = "Welcome to C#!";
    const string COUNTRY = "भारत";

    static void Main()
    {
        // Демонстрация констант значимых типов
        WriteLine($"Maximum Age: {MAX_AGE}");
        WriteLine($"Value of Pi: {PI}");
        WriteLine($"Are we humans? {IS_HUMAN}");

        // Демонстрация констант ссылочных типов
        WriteLine($"Default Message: {DEFAULT_MESSAGE}");
        WriteLine($"Country: {COUNTRY}");
        
        // Попытка изменить значение (раскомментируйте строку ниже для проверки)
        // MAX_AGE = 130; // Ошибка: CS0131 - Константа не может быть изменена
    }
}