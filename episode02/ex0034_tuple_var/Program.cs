using System;

class Program
{
    static void Main()
    {
        // 1. Создание неименованного кортежа
        var point = (10, 20);
        WriteLine($"X: {point.Item1}, Y: {point.Item2}");

        // 2. Создание именованного кортежа
        (int x, int y) namedPoint = (30, 40);
        WriteLine($"X: {namedPoint.x}, Y: {namedPoint.y}");

        // 3. Возврат значений из метода
        var rectangle = GetRectangleInfo();
        WriteLine($"Width: {rectangle.width}, Height: {rectangle.height}, Area: {rectangle.area}");

        // 4. Кортеж с другими типами
        var mixed = (true, 3.14, "Hello");
        WriteLine($"Boolean: {mixed.Item1}, Double: {mixed.Item2}, String: {mixed.Item3}");

        // 5. Использование класса Tuple
        var oldTuple = Tuple.Create(25, "Alice");
        WriteLine($"Age: {oldTuple.Item1}, Name: {oldTuple.Item2}");
    }

    // Метод возвращает кортеж с информацией о прямоугольнике
    static (int width, int height, int area) GetRectangleInfo()
    {
        int width = 5;
        int height = 10;
        int area = width * height;
        return (width, height, area);
    }
}