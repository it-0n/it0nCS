using System;

class Program
{
    enum DaysOfWeek { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }

    [Flags]
    enum Permissions { None = 0, Read = 1, Write = 2, Execute = 4 }

    static void Main()
    {
        // 1. Присваивание
        DaysOfWeek today = DaysOfWeek.Wednesday;
        WriteLine($"Сегодня: {today}");

        // 2. Приведение типов
        int dayCode = (int)today;
        WriteLine($"Код сегодняшнего дня: {dayCode}");

        DaysOfWeek tomorrow = (DaysOfWeek)(dayCode + 1);
        WriteLine($"Завтра: {tomorrow}");

        // 3. Сравнение
        if (tomorrow > today)
            WriteLine("Завтра позже, чем сегодня.");

        // 4. Побитовые операции
        Permissions userPermissions = Permissions.Read | Permissions.Write;
        if ((userPermissions & Permissions.Write) != 0)
            WriteLine("Есть право на запись.");

        // 5. Enum.GetValues()
        WriteLine("Все дни недели:");
        foreach (var value in Enum.GetValues(typeof(DaysOfWeek)))
            WriteLine($"{value} = {(int)value}");

        // 6. Преобразование строки в перечисление
        DaysOfWeek parsedDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), "Friday");
        WriteLine($"Из строки: {parsedDay}");
    }
}
