namespace ex0015_integer_vars;

class Program
{
    static sbyte sbyteDefault;
    static sbyte byteDefault;
    static short shortDefault;
    static ushort ushortDefault;
    static int intDefault;
    static uint uintDefault;
    static long longDefault;
    static ulong ulongDefault;
    static nint nintDefault;
    static nuint nuintDefault;

    static void Main()
    {
        WriteLine("Типы целочисленных переменных в C#");
        WriteLine(new string('-', 34));

        // sbyte
        sbyte sbyteMin = sbyte.MinValue;
        sbyte sbyteMax = sbyte.MaxValue;
        
        WriteLine($"Тип: sbyte");
        WriteLine($"Минимум: {sbyteMin}");
        WriteLine($"Максимум: {sbyteMax}");
        WriteLine($"Значение по умолчанию: {sbyteDefault}");
        WriteLine();

        // byte
        byte byteMin = byte.MinValue;
        byte byteMax = byte.MaxValue;
        WriteLine($"Тип: byte");
        WriteLine($"Минимум: {byteMin}");
        WriteLine($"Максимум: {byteMax}");
        WriteLine($"Значение по умолчанию: {byteDefault}");
        WriteLine();

        // short
        short shortMin = short.MinValue;
        short shortMax = short.MaxValue;
        WriteLine($"Тип: short");
        WriteLine($"Минимум: {shortMin}");
        WriteLine($"Максимум: {shortMax}");
        WriteLine($"Значение по умолчанию: {shortDefault}");
        WriteLine();

        // ushort
        ushort ushortMin = ushort.MinValue;
        ushort ushortMax = ushort.MaxValue;
        WriteLine($"Тип: ushort");
        WriteLine($"Минимум: {ushortMin}");
        WriteLine($"Максимум: {ushortMax}");
        WriteLine($"Значение по умолчанию: {ushortDefault}");
        WriteLine();

        // int
        int intMin = int.MinValue;
        int intMax = int.MaxValue;
        WriteLine($"Тип: int");
        WriteLine($"Минимум: {intMin}");
        WriteLine($"Максимум: {intMax}");
        WriteLine($"Значение по умолчанию: {intDefault}");
        WriteLine();

        // uint
        uint uintMin = uint.MinValue;
        uint uintMax = uint.MaxValue;
        WriteLine($"Тип: uint");
        WriteLine($"Минимум: {uintMin}");
        WriteLine($"Максимум: {uintMax}");
        WriteLine($"Значение по умолчанию: {uintDefault}");
        WriteLine();

        // long
        long longMin = long.MinValue;
        long longMax = long.MaxValue;
        WriteLine($"Тип: long");
        WriteLine($"Минимум: {longMin}");
        WriteLine($"Максимум: {longMax}");
        WriteLine($"Значение по умолчанию: {longDefault}");
        WriteLine();

        // ulong
        ulong ulongMin = ulong.MinValue;
        ulong ulongMax = ulong.MaxValue;
        WriteLine($"Тип: ulong");
        WriteLine($"Минимум: {ulongMin}");
        WriteLine($"Максимум: {ulongMax}");
        WriteLine($"Значение по умолчанию: {ulongDefault}");
        WriteLine();

        // nint (платформо-зависимый тип)
        nint nintMin = nint.MinValue;
        nint nintMax = nint.MaxValue;
        WriteLine($"Тип: nint");
        WriteLine($"Минимум: {nintMin}");
        WriteLine($"Максимум: {nintMax}");
        WriteLine($"Значение по умолчанию: {nintDefault}");
        WriteLine();

        // nuint (платформо-зависимый тип)
        nuint nuintMin = nuint.MinValue;
        nuint nuintMax = nuint.MaxValue;
        
        WriteLine($"Тип: nuint");
        WriteLine($"Минимум: {nuintMin}");
        WriteLine($"Максимум: {nuintMax}");
        WriteLine($"Значение по умолчанию: {nuintDefault}");
        WriteLine();
    }
}
