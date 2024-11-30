using System;

namespace IntegerOperations;

public static class BitwiseOperatins
{
    public static void ShowInBinary()
    {
        // Положительные переменные
        byte a = 0b0011_1100; // 60 в десятичной системе
        byte b = 0b0000_1101; // 13 в десятичной системе
        WriteLine($"a: {a} (десятичные), {Convert.ToString(a, 2).PadLeft(8, '0')} (двоичные)");
        WriteLine($"b: {b} (десятичные), {Convert.ToString(b, 2).PadLeft(8, '0')} (двоичные)");

        // Отрицательная переменная (двоичный литерал для -60)
        sbyte negA = unchecked((sbyte)0b1100_0100); // Двоичный литерал для -60
        WriteLine($"negA: {negA} (десятичные), {Convert.ToString((byte)negA, 2).PadLeft(8, '0')} (двоичные)");

        WriteLine("\n=== Побитовые операции для byte и sbyte в двоичном и десятичном представлении ===");

        // Побитовая И (AND)
        byte andResult = (byte)(a & b);
        WriteLine($"a & b: {Convert.ToString(a, 2).PadLeft(8, '0')} & {Convert.ToString(b, 2).PadLeft(8, '0')} = {Convert.ToString(andResult, 2).PadLeft(8, '0')} (двоичные), {a} & {b} = {andResult} (десятичные)");

        // Побитовая ИЛИ (OR)
        byte orResult = (byte)(a | b);
        WriteLine($"a | b: {Convert.ToString(a, 2).PadLeft(8, '0')} | {Convert.ToString(b, 2).PadLeft(8, '0')} = {Convert.ToString(orResult, 2).PadLeft(8, '0')} (двоичные), {a} | {b} = {orResult} (десятичные)");

        // Побитовая исключающая ИЛИ (XOR)
        byte xorResult = (byte)(a ^ b);
        WriteLine($"a ^ b: {Convert.ToString(a, 2).PadLeft(8, '0')} ^ {Convert.ToString(b, 2).PadLeft(8, '0')} = {Convert.ToString(xorResult, 2).PadLeft(8, '0')} (двоичные), {a} ^ {b} = {xorResult} (десятичные)");

        // Побитовая инверсия (NOT)
        byte notA = (byte)~a;
        sbyte notNegA = (sbyte)~negA;
        WriteLine($"~a: ~{Convert.ToString(a, 2).PadLeft(8, '0')} = {Convert.ToString(notA, 2).PadLeft(8, '0')} (двоичные), ~{a} = {notA} (десятичные)");
        WriteLine($"~negA: ~{Convert.ToString((byte)negA, 2).PadLeft(8, '0')} = {Convert.ToString((byte)notNegA, 2).PadLeft(8, '0')} (двоичные), ~{negA} = {notNegA} (десятичные)");

        WriteLine("\n=== Побитовые сдвиги для byte и sbyte в двоичном и десятичном представлении ===");

        // Сдвиг влево
        byte shiftLeftA = (byte)(a << 2);
        sbyte shiftLeftNegA = (sbyte)(negA << 2);
        WriteLine($"a << 2: {Convert.ToString(a, 2).PadLeft(8, '0')} << 2 = {Convert.ToString(shiftLeftA, 2).PadLeft(8, '0')} (двоичные), {a} << 2 = {shiftLeftA} (десятичные)");
        WriteLine($"negA << 2: {Convert.ToString((byte)negA, 2).PadLeft(8, '0')} << 2 = {Convert.ToString((byte)shiftLeftNegA, 2).PadLeft(8, '0')} (двоичные), {negA} << 2 = {shiftLeftNegA} (десятичные)");

        // Сдвиг вправо
        byte shiftRightA = (byte)(a >> 2);
        sbyte shiftRightNegA = (sbyte)(negA >> 2);
        WriteLine($"a >> 2: {Convert.ToString(a, 2).PadLeft(8, '0')} >> 2 = {Convert.ToString(shiftRightA, 2).PadLeft(8, '0')} (двоичные), {a} >> 2 = {shiftRightA} (десятичные)");
        WriteLine($"negA >> 2: {Convert.ToString((byte)negA, 2).PadLeft(8, '0')} >> 2 = {Convert.ToString((byte)shiftRightNegA, 2).PadLeft(8, '0')} (двоичные), {negA} >> 2 = {shiftRightNegA} (десятичные)");
    }
}