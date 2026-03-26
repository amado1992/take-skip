public static class StringExtensions
{
    // This extension method reverses a given string.
    public static string Reverse(this string input)
    {
        // Convert the string to a character array.
        char[] chars = input.ToCharArray();
        // Reverse the array in place.
        Array.Reverse(chars);
        // Create a new string from the reversed character array and return it.
        return new string(chars);
    }
}
