using System;

class Program
{
    // Определяем перечисление с днями недели
    enum DaysOfWeek
    {
        Sunday = 0,  // Первое значение
        Monday,      // Автоматически 1
        Tuesday,     // Автоматически 2
        Wednesday,   // Автоматически 3
        Thursday,    // Автоматически 4
        Friday,      // Автоматически 5
        Saturday     // Автоматически 6
    }

    static void Main()
    {
        // Создаем переменную типа DaysOfWeek и присваиваем значение из перечисления
        DaysOfWeek today = DaysOfWeek.Wednesday;
        WriteLine($"Сегодня: {today}, Код: {(int)today}");

        // Присваиваем значение с использованием числового кода
        DaysOfWeek tomorrow = (DaysOfWeek)4;
        WriteLine($"Завтра: {tomorrow}");

        // Выводим все элементы перечисления
        WriteLine("Все дни недели:");
        foreach (DaysOfWeek day in Enum.GetValues(typeof(DaysOfWeek)))
        {
            WriteLine($"{day} = {(int)day}");
        }

        // Присваиваем значение числом с явным приведением
        DaysOfWeek specificDay = (DaysOfWeek)1;
        WriteLine($"День с кодом 1: {specificDay}");
    }
}
