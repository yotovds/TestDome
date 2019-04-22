using System;

public class Palindrome
{
    public static bool IsPalindrome(string word)
    {
        var reversedWord = string.Empty;
        for (int i = word.Length - 1; i >= 0; i--)
        {
            reversedWord += word[i];
        }

        return word.ToLower() == reversedWord.ToLower();
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(Palindrome.IsPalindrome("Deleveled"));
    }
}