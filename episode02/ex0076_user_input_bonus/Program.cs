WriteLine("Hello from TinyConsoleTemplate with classic Main method!");
string? name = ReadInput("What is your name? ");
name = string.IsNullOrEmpty(name) ? "Anonymous" : name.Trim();
WriteLine($"Hello, {name}! Enjoy using the TinyConsoleTemplate and the TinyConsoleUtils library to create cool C# console applications!");