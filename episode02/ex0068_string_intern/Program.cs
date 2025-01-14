using System;

class Program
{
    static void Main()
    {
        WriteLine("=== Работа с String.Intern ===");

        string str1 = "CSharp"; // Интернированная строка
        string str2 = new string("CSharp".ToCharArray()); // Не интернированная строка
        WriteLine(Object.ReferenceEquals(str1, str2)); // False

        string internedStr = String.Intern(str2); // Интернируем строку
        WriteLine(Object.ReferenceEquals(str1, internedStr)); // True

        WriteLine("\n=== Работа с String.IsInterned ===");

        string str3 = "Programming"; // Интернированная строка
        string str4 = new string("Programming".ToCharArray()); // Не интернированная строка

        WriteLine(String.IsInterned(str3) != null ? "str3 интернирована" : "str3 не интернирована"); // str3 интернирована
        WriteLine(String.IsInterned(str4) != null ? "str4 интернирована" : "str4 не интернирована"); // str4 не интернирована

        String.Intern(str4); // Интернируем str4
        WriteLine(String.IsInterned(str4) != null ? "str4 интернирована" : "str4 не интернирована"); // str4 интернирована
    }
}