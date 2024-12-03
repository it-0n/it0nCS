using System;

class Program
{
    static void Main()
    {
        WriteLine("Используем double:");
        double aDouble = 0.1;
        double bDouble = 0.2;

        WriteLine($"Обычное представление aDouble: {aDouble}");
        WriteLine($"Обычное представление bDouble: {bDouble}");

        // Вывод фактических значений с максимально точным представлением до 20 знаков после запятой
        WriteLine($"Точное представление aDouble (до 20 знаков): {aDouble:F20}");
        WriteLine($"Точное представление bDouble (до 20 знаков): {bDouble:F20}");

        if (aDouble + bDouble == 0.3)
        {
            WriteLine($"{aDouble} + {bDouble} равно {0.3}");
        }
        else
        {
            WriteLine($"{aDouble} + {bDouble} НЕ равно {0.3}");
            WriteLine($"Фактический результат: {aDouble + bDouble}");
        }

        WriteLine();

        WriteLine("Используем decimal:");
        decimal aDecimal = 0.1m;
        decimal bDecimal = 0.2m;

        if (aDecimal + bDecimal == 0.3m)
        {
            WriteLine($"{aDecimal} + {bDecimal} равно {0.3m}");
        }
        else
        {
            WriteLine($"{aDecimal} + {bDecimal} НЕ равно {0.3m}");
            WriteLine($"Фактический результат: {aDecimal + bDecimal}");
        }

        WriteLine();

        WriteLine("Сравнение double с использованием epsilon:");
        double epsilon = 1e-15; // Очень маленькое число определяющее допустимую погрешность
        if (Math.Abs(aDouble + bDouble - 0.3) < epsilon)
        {
            WriteLine($"{aDouble} + {bDouble} примерно равно {0.3} (с учетом epsilon)");
        }
        else
        {
            WriteLine($"{aDouble} + {bDouble} НЕ равно {0.3} даже с учетом epsilon");
        }
    }
}
