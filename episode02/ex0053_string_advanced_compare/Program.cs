using System;

class Program
{
    static void Main()
    {
        // CompareOrdinal
        int compareOrdinal = String.CompareOrdinal("apple", "banana");
        WriteLine($"CompareOrdinal: {compareOrdinal}");

        // Compare
        int compare = String.Compare("apple", "Apple", true);
        WriteLine($"Compare (ignore case): {compare}");

        // CompareTo
        int compareTo = "apple".CompareTo("banana");
        WriteLine($"CompareTo: {compareTo}");

        // StartsWith
        bool startsWith = "hello world".StartsWith("hello");
        WriteLine($"StartsWith: {startsWith}");

        // EndsWith
        bool endsWith = "hello world".EndsWith("world");
        WriteLine($"EndsWith: {endsWith}");

        // Contains
        bool contains = "hello world".Contains("lo wo");
        WriteLine($"Contains: {contains}");

        // IndexOf
        int indexOf = "hello world".IndexOf("world");
        WriteLine($"IndexOf: {indexOf}");

        // LastIndexOf
        int lastIndexOf = "hello world world".LastIndexOf("world");
        WriteLine($"LastIndexOf: {lastIndexOf}");
    }
}