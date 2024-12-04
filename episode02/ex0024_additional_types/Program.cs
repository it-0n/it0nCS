using System;

class Program
{
    unsafe static void Main()
    {
        // Создание переменных новых типов данных
        Half halfNumber = (Half)1.23f; // Тип Half, явное приведение

        // Для Int128 и UInt128 используем разделение на старшую и младшую часть
        ulong lowerInt128 = 12345678901234567890UL; // Младшая часть
        ulong upperInt128 = 12345678901234567890UL; // Старшая часть
        Int128 int128Number = new Int128(lowerInt128, upperInt128); // Тип Int128, создаем из двух частей

        ulong lowerUInt128 = 12345678901234567890UL; // Младшая часть
        ulong upperUInt128 = 12345678901234567890UL; // Старшая часть
        UInt128 uint128Number = new UInt128(lowerUInt128, upperUInt128); // Тип UInt128, создаем из двух частей

        // Вывод значений переменных
        WriteLine($"Значение типа Half: {halfNumber}");
        WriteLine($"Значение типа Int128: {int128Number}");
        WriteLine($"Значение типа UInt128: {uint128Number}");

        // Размеры типов данных в памяти
        WriteLine($"Размер типа Half: {sizeof(Half)} байт");
        WriteLine($"Размер типа Int128: {sizeof(Int128)} байт");
        WriteLine($"Размер типа UInt128: {sizeof(UInt128)} байт");

        // Диапазоны значений
        WriteLine($"Диапазон значений Half: {Half.MinValue} до {Half.MaxValue}");
        WriteLine($"Диапазон значений Int128: {Int128.MinValue} до {Int128.MaxValue}");
        WriteLine($"Диапазон значений UInt128: {UInt128.MinValue} до {UInt128.MaxValue}");
    }
}
