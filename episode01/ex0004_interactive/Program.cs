// See https://aka.ms/new-console-template for more information
Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");
Console.Write("Как тебя зовут, о падаван? ");
var padavanName = Console.ReadLine();
Console.WriteLine($"Приветствую тебя, {padavanName}! Да пребудет с тобой Сила!");
