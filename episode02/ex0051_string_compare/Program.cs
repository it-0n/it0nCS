using System;

class Program
{
    static void Main()
    {
        string str1 = "hello";
        string str2 = "Hello";
        string str3 = new string("hello".ToCharArray());

        // Операторы == и !=
        WriteLine(str1 == str2); // False
        WriteLine(str1 != str2); // True

        // Метод Equals
        WriteLine(str1.Equals(str2)); // False
        WriteLine(str1.Equals(str2, StringComparison.OrdinalIgnoreCase)); // True

        // Сравнение ссылок
        WriteLine(object.ReferenceEquals(str1, str3)); // False

        // Compare
        WriteLine(string.Compare(str1, str2, StringComparison.OrdinalIgnoreCase)); // 0

        // CompareTo
        WriteLine(str1.CompareTo(str2)); // Отрицательное значение, "hello" меньше "Hello"
    }
}