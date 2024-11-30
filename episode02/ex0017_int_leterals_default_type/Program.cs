namespace IntLiteralsDefaultVal;

class Program
{
    static sbyte a0b, a0x, b, c, d;
    static int intN = 196;

    static void Main()
    {
        a0b = unchecked((sbyte)0b1100_0100); // 196 без знаковое, -60 знаковое
        a0x = unchecked((sbyte)0xC4); // 196 без знаковое, -60 знаковое
        b = unchecked((sbyte)196);
        c = (sbyte)intN;
        d = (sbyte)(intN - 136);

        WriteLine($"{a0b} {a0x} {b} {c} {d} {intN}");
    }
}
