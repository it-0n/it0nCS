WriteLine($"Операционная система: {System.Runtime.InteropServices.RuntimeInformation.OSDescription}");
WriteLine($"Текущая директория: {Env.CurrentDirectory}");
WriteLine("Имя класса: {0}", typeof(Program).Name);
WriteLine("Имя пространства имён класса: {0}", typeof(Program).Namespace);
WriteLine("Полное имя: {0}", typeof(Program).FullName);
WriteLine($"Имя компьютера {Env.MachineName}");
WriteLine($"Текущий метод: {System.Reflection.MethodBase.GetCurrentMethod()?.Name}");
