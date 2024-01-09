

using System;

public class StringReverser
{
    public string ReverseString(string input)
    {
        // Logik för att vända på strängen
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
