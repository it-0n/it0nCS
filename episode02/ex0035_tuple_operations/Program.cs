class Program
{
    static void Main()
    {
        // 1. Создание кортежей
        var tuple1 = (1, "Hello", true); // Неименованный кортеж
        var tuple2 = (Id: 42, Name: "Alice", IsActive: false); // Именованный кортеж

        WriteLine($"Кортеж 1: {tuple1}");
        WriteLine($"Кортеж 2: {tuple2}");

        // 2. Доступ к элементам
        WriteLine($"Первый элемент кортежа 1: {tuple1.Item1}");
        WriteLine($"Имя из кортежа 2: {tuple2.Name}");

        // 3. Декомпозиция
        var (id, name, isActive) = tuple2;
        WriteLine($"Декомпозиция: Id = {id}, Name = {name}, IsActive = {isActive}");

        // 4. Присваивание
        var tuple3 = (10, "World");
        tuple3 = (20, "C#");
        WriteLine($"Новый кортеж: {tuple3}");

        // 5. Сравнение
        var t1 = (5, 10);
        var t2 = (5, 10);
        WriteLine($"Равны ли т1 и т2? {t1 == t2}");

        // 6. Вложенные кортежи
        var nestedTuple = (1, ("A", 2.5), true);
        WriteLine($"Вложенный кортеж: {nestedTuple.Item2.Item1}, {nestedTuple.Item2.Item2}");

        // 7. Возврат кортежа из метода
        var result = GetUserInfo(101);
        WriteLine($"Пользователь: Id = {result.Id}, Name = {result.Name}, Role = {result.Role}");

        // 8. Изменение значений через ref
        var tupleRef = (X: 10, Y: 20);
        ModifyTuple(ref tupleRef);
        WriteLine($"Модифицированный кортеж: X = {tupleRef.X}, Y = {tupleRef.Y}");

        // 9. Кортежи в коллекциях
        var listOfTuples = new[] { (1, "Item1"), (2, "Item2"), (3, "Item3") };
        foreach (var item in listOfTuples)
        {
            WriteLine($"Коллекция кортежей: Id = {item.Item1}, Name = {item.Item2}");
        }

        // 10. Сопоставление с образцом
        if (tuple2 is (42, _, false))
        {
            WriteLine("Совпало с шаблоном (42, _, false)");
        }
    }

    // Метод, возвращающий кортеж
    static (int Id, string Name, string Role) GetUserInfo(int id)
    {
        return (id, "John Doe", "Admin");
    }

    // Метод для изменения значений кортежа через ref
    static void ModifyTuple(ref (int X, int Y) tuple)
    {
        tuple.X += 10;
        tuple.Y += 10;
    }
}