struct Rectangle
{
    public double Width;  // Ширина (изменяемое поле)
    public double Height; // Высота

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double CalculateArea()
    {
        return Width * Height; // Возвращает площадь
    }
}

class Program
{
    static void Main()
    {
        // Создаём экземпляр структуры в стеке
        Rectangle rect = new Rectangle(4.5, 7.3);
        WriteLine($"Площадь: {rect.CalculateArea()}");

        // Изменяем ширину
        rect.Width = 10;
        WriteLine($"Новая ширина: {rect.Width}");
        WriteLine($"Площадь после изменения: {rect.CalculateArea()}");
    }
}
