using System;

class Program
{
    static void Main()
    {
        // Создание переменных для вещественных типов
        float floatVal1 = 5.5f;
        float floatVal2 = 2.5f;
        
        double doubleVal1 = 3.14;
        double doubleVal2 = 1.57;
        
        decimal decimalVal1 = 10.1234m;
        decimal decimalVal2 = 5.5m;

        // Арифметические операции с выводом на экран
        WriteLine($"float: {floatVal1} + {floatVal2} = {floatVal1 + floatVal2}");
        WriteLine($"float: {floatVal1} - {floatVal2} = {floatVal1 - floatVal2}");
        WriteLine($"float: {floatVal1} * {floatVal2} = {floatVal1 * floatVal2}");
        WriteLine($"float: {floatVal1} / {floatVal2} = {floatVal1 / floatVal2}");
        WriteLine($"float: {floatVal1} % {floatVal2} = {floatVal1 % floatVal2}");
        
        WriteLine($"double: {doubleVal1} + {doubleVal2} = {doubleVal1 + doubleVal2}");
        WriteLine($"double: {doubleVal1} - {doubleVal2} = {doubleVal1 - doubleVal2}");
        WriteLine($"double: {doubleVal1} * {doubleVal2} = {doubleVal1 * doubleVal2}");
        WriteLine($"double: {doubleVal1} / {doubleVal2} = {doubleVal1 / doubleVal2}");
        
        WriteLine($"decimal: {decimalVal1} + {decimalVal2} = {decimalVal1 + decimalVal2}");
        WriteLine($"decimal: {decimalVal1} - {decimalVal2} = {decimalVal1 - decimalVal2}");
        WriteLine($"decimal: {decimalVal1} * {decimalVal2} = {decimalVal1 * decimalVal2}");
        // Для decimal остаток от деления не поддерживается
        // WriteLine($"decimal: {decimalVal1} % {decimalVal2} = {decimalVal1 % decimalVal2}");

        // Математические операции
        double squareRoot = Math.Sqrt(doubleVal1);
        double power = Math.Pow(2.0, 3.0);
        decimal absoluteValue = Math.Abs(decimalVal1);

        WriteLine($"Квадратный корень из {doubleVal1}: {squareRoot}");
        WriteLine($"Возведение 2 в степень 3: {power}");
        WriteLine($"Абсолютное значение {decimalVal1}: {absoluteValue}");

        // Округления
        double roundedValue = Math.Round(3.14159);
        double ceilValue = Math.Ceiling(3.14);
        double floorValue = Math.Floor(3.14);

        WriteLine($"Округление (Round): {roundedValue}");
        WriteLine($"Округление вверх (Ceiling): {ceilValue}");
        WriteLine($"Округление вниз (Floor): {floorValue}");

        // Преобразования типов
        double doubleFromFloat = (double)floatVal1;
        decimal decimalFromDouble = (decimal)doubleVal1;

        WriteLine($"Преобразование float в double: {doubleFromFloat}");
        WriteLine($"Преобразование double в decimal: {decimalFromDouble}");
    }
}
