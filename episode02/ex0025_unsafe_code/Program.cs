class Program
{
    unsafe static void Main()
    {
        int number = 42;

        // Получение указателя на переменную
        int* pointer = &number;

        WriteLine($"Значение переменной: {number}");
        WriteLine($"Адрес в памяти: {(long)pointer}");
        WriteLine($"Значение через указатель: {*pointer}");

        // Изменение значения через указатель
        *pointer = 100;
        WriteLine($"Новое значение переменной: {number}");
    }
}