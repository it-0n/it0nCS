// See https://aka.ms/new-console-template for more information
Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");
Console.Write("О падаван, зовут тебя как? ");
var padavanName = Console.ReadLine();
Console.WriteLine($"О {padavanName}, тебя приветствую я!\nИ да пребудет с тобой сила!");
