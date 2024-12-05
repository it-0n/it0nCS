using System;

class Program
{
    static void Main()
    {
        // 1. Арифметические операции
        char a = 'A';
        char b = (char)(a + 1);
        WriteLine($"Сложение: {a} + 1 = {b}");
        char c = (char)(b - 1);
        WriteLine($"Вычитание: {b} - 1 = {c}");
        int product = a * 2;
        WriteLine($"Умножение: {a} * 2 = {product}");
        
        // 2. Инкремент и декремент
        char d = 'A';
        d++;
        WriteLine($"Инкремент: {d}");
        d--;
        WriteLine($"Декремент: {d}");
        
        // 3. Побитовые операции
        char e = 'A';
        char f = (char)(e & 0xFF);
        WriteLine($"Побитовая И: {e} & 0xFF = {f}");
        char g = (char)(e | 0x20);
        WriteLine($"Побитовая ИЛИ: {e} | 0x20 = {g}");
        
        // 4. Логические операции
        char h = 'A', i = 'B';
        WriteLine($"Равно: {h} == {i} = {h == i}");
        WriteLine($"Меньше: {h} < {i} = {h < i}");
        
        // 5. Операции присваивания
        char j = 'A';
        j += (char)1; // поскольку 1 это тип int по умолчанию необходимо явное приведение к типу char
        WriteLine($"Сложение с присваиванием: {j}");
        j &= (char)0xFF; // смотри комментарий выше
        WriteLine($"Побитовая И с присваиванием: {j}");
        
        // 6. Унарные операции
        char k = 'A';
        int unicodeValue = +k;
        WriteLine($"Унарная операция +: {unicodeValue}");
        
        // 7. Приведение типов
        int l = 'A';
        char m = (char)66;
        WriteLine($"Неявное приведение: {l}");
        WriteLine($"Явное приведение: {m}");
        
        // 8. Проверка переполнения
        char n = (char)65535;
        char o = unchecked((char)(n + 1));
        WriteLine($"Переполнение: {o} (Unicode {Convert.ToInt32(o)})");
    }
}
