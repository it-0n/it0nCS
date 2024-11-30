using System;

namespace IntegerOperations;

class Program
{
    static void Main(string[] args)
    {
        // Арифметические операции
        int a = 10; // объявление переменной a и инициализация её значением 10
        int b; // объявление переменной b
        b = 3; //  присвоение переменной b значения 3
        WriteLine("Арифметические операции:");
        WriteLine($"Значения в начале демонстрации a = {a},   b = {b}");
        WriteLine($"{a} + {b} = {a + b}");
        WriteLine($"{a} - {b} = {a - b}");
        WriteLine($"{a} * {b} = {a * b}");
        WriteLine($"{a} / {b} = {a / b}");
        WriteLine($"{a} % {b} = {a % b}");
        WriteLine($"Значения в конце демонстрации a = {a},   b = {b}");

        // Инкремент и декремент
        WriteLine("\nИнкремент и декремент:");
        int c = 5;
        WriteLine($"Значение в начале демонстрации c = {c}");
        WriteLine($"Префиксный инкремент ++c: {c} -> {++c}"); // сначала применяется операция ++ потом выводится значение
        WriteLine($"Постфиксный инкремент c++: {c++} -> {c}"); // сперва выводится значение потом применяется операция ++
        WriteLine($"Префиксный декремент --c: {c} -> {--c}"); // сначала применяется операция -- потом выводится значение
        WriteLine($"Постфиксный декремент c--: {c--} -> {c}"); // сперва выводится значение потом применяется операция --
        ++c; // увеличили значение переменной c на 1
        WriteLine($"Значение в конце демонстрации c = {c}");

        // Побитовые операции
        WriteLine("\nПобитовые операции в десятичном представлении:");
        a = 5; // присвоили переменной a значение 5 в двоичном виде это 0101
        b = 3; // присвоили переменной b значение 3 в двоичном виде это 0011
        WriteLine($"Значения в начале демонстрации a = {a},   b = {b}");
        WriteLine($"{a} & {b} = {a & b}"); // 0001
        WriteLine($"{a} | {b} = {a | b}"); // 0111
        WriteLine($"{a} ^ {b} = {a ^ b}"); // 0110
        WriteLine($"~{a} = {~a}");       // ...1010 (дополнение до отрицательного числа)
        WriteLine($"{a} << 1 = {a << 1}"); // 1010
        WriteLine($"{a} >> 1 = {a >> 1}"); // 0010
        WriteLine($"Значения в конце демонстрации a = {a},   b = {b}\n");

        BitwiseOperatins.ShowInBinary(); // вызов статического метода ShowInBinary() статического класса BitwiseOperatins

        // Логические операции
        WriteLine("\nЛогические операции:");
        a = 15; // присвоили переменной a значение 15
        b = 5; // присовили переменной b значение 5
        WriteLine($"Значения в начале демонстрации a = {a},   b = {b}");
        WriteLine($"{a} == {b}: {a == b}");
        WriteLine($"{a} != {b}: {a != b}");
        WriteLine($"{a} > {b}: {a > b}");
        WriteLine($"{a} < {b}: {a < b}");
        WriteLine($"{a} >= {b}: {a >= b}");
        WriteLine($"{a} <= {b}: {a <= b}");
        WriteLine($"Значения в конце демонстрации a = {a},   b = {b}");

        // Операции присваивания
        WriteLine("\nОперации присваивания:");
        int d = 10;
        WriteLine($"Значение в начале демонстрации d = {d}");
        d += 5; WriteLine($"{d} += 5 -> {d}");
        d -= 3; WriteLine($"{d} -= 3 -> {d}");
        d *= 2; WriteLine($"{d} *= 2 -> {d}");
        d /= 4; WriteLine($"{d} /= 4 -> {d}");
        d %= 3; WriteLine($"{d} %= 3 -> {d}");
        d &= 2; WriteLine($"{d} &= 2 -> {d}");
        d |= 1; WriteLine($"{d} |= 1 -> {d}");
        d ^= 3; WriteLine($"{d} ^= 3 -> {d}");
        d <<= 2; WriteLine($"{d} <<= 2 -> {d}");
        d >>= 1; WriteLine($"{d} >>= 1 -> {d}");
        WriteLine($"Значение в конце демонстрации d = {d}");

        // Унарная операция смены знака
        WriteLine("\nУнарная операция смены знака:");
        int originalNumber = 42; // Исходное число
        int negativeNumber = -originalNumber; // Меняем знак на отрицательный        
        int positiveNumber = -negativeNumber; // Меняем знак обратно на положительный
        WriteLine($"Исходное число: {originalNumber}");
        WriteLine($"Число с отрицательным знаком: {negativeNumber}");
        WriteLine($"Число с положительным знаком: {positiveNumber}");

        // Приведение типов
        WriteLine("\nПриведение типов:");
        long bigValue = 1000L;
        int smallValue = (int)bigValue; // Явное приведение
        WriteLine($"Явное приведение: long -> int: {smallValue}");
        int value = 100;
        long largeValue = value; // Неявное приведение
        WriteLine($"Неявное приведение: int -> long: {largeValue}");

        // Операции проверки переполнения
        WriteLine("\nПроверка переполнения:");
        sbyte x = unchecked((sbyte)196); // 196 выходит за пределы диапазона sbyte
        WriteLine($"С разрешенным переполнением unchecked: x = {x}"); // Ожидается результат: -60

        // Пример с checked: будет выброшено исключение OverflowException
        WriteLine($"\nС запрещенным переполнением checked:");
        try
        {
            int z = 196;
            WriteLine($"\nz = {z}");
            sbyte y = checked((sbyte)z);
            WriteLine($"Checked: y = {y}");
        }
        catch (OverflowException ex)
        {
            WriteLine($"Checked: Переполнение типа: {ex.Message}");
        }

        try
        {
            int z = -128;
            WriteLine($"\nz = {z}");
            sbyte y = checked((sbyte)z);
            WriteLine($"Checked: y = {y}");
        }
        catch (OverflowException ex)
        {
            WriteLine($"Checked: Переполнение типа: {ex.Message}");
        }
    }
}
