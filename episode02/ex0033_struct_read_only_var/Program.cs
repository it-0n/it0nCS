struct Rectangle
{
    public readonly double Width;  // Поля неизменяемы
    public readonly double Height;

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double CalculateArea()
    {
        return Width * Height; // Возвращает площадь
    }

    // Метод для создания новой структуры с другой шириной
    public Rectangle WithWidth(double newWidth)
    {
        return new Rectangle(newWidth, Height);
    }
}

class Program
{
    static void Main()
    {
        Rectangle rect = new Rectangle(4.5, 7.3);
        WriteLine($"Площадь: {rect.CalculateArea()}");

        // Создаём новую структуру с изменённой шириной
        Rectangle newRect = rect.WithWidth(10);
        WriteLine($"Старая ширина: {rect.Width}, новая ширина: {newRect.Width}");
        WriteLine($"Площадь нового прямоугольника: {newRect.CalculateArea()}");
    }
}