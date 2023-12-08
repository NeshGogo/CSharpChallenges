namespace CodeChallenges.StringManipulations;

public static class CheckPalindrome
{

  public static void Display(){
    Console.WriteLine("--Checking if a word is a Palindrome--");
    Console.WriteLine("Write a word:");
    var val = Console.ReadLine();
    var result = IsPalindrome(val);
    var negation = !result? " not": "";
    Console.WriteLine($"---> The word is{negation} palindrome <---");
  }

  private static bool IsPalindrome(string val){
    string reverseVal = string.Join("", val.Reverse());
    return string.Equals(val.ToLower(), reverseVal.ToLower());
  }
}
