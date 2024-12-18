class Program
{
    static void Main()
    {
        // Пример типа значения
        int value1 = 10;
        int value2 = value1;
        value2 += 5;
        WriteLine($"Тип значения: value1 = {value1}, value2 = {value2}"); // value1 = 10, value2 = 15

        // Пример ссылочного типа Class
        Person p1 = new Person { Name = "Alice" };
        Person p2 = p1; // Копируется ссылка на объект
        p2.Name = "Bob";
        WriteLine($"Ссылочный тип: p1.Name = {p1.Name}, p2.Name = {p2.Name}"); // p1.Name = Bob, p2.Name = Bob
    }
}

class Person
{
    public string Name;
}