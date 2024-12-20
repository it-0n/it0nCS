using System.Collections.Generic;

public class VarExample
{
    public static void Main()
    {
        // Пример с типами значений
        var number = 42; // Компилятор определяет тип как int
        var pi = 3.14; // Компилятор определяет тип как double
        var isHappy = true; // Компилятор определяет тип как bool

        // Пример с ссылочными типами
        var message = "Hello, World!"; // Компилятор определяет тип как string
        var numbers = new List<int> { 1, 2, 3 }; // Компилятор определяет тип как List<int>
        
        // Пример с анонимным типом
        var student = new { Name = "Alice", Grade = "A" }; // Компилятор определяет тип как анонимный объект

        // Вывод данных
        WriteLine($"Number: {number}, Type: {number.GetType()}");
        WriteLine($"Pi: {pi}, Type: {pi.GetType()}");
        WriteLine($"IsHappy: {isHappy}, Type: {isHappy.GetType()}");
        WriteLine($"Message: {message}, Type: {message.GetType()}");
        WriteLine($"Numbers: {string.Join(", ", numbers)}, Type: {numbers.GetType()}");
        WriteLine($"Student: {student.Name}, {student.Grade}, Type: {student.GetType()}");
    }
}