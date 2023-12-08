namespace CodeChallenges;

public static class StringReverser
{
  public static void Display()
  {
    Console.WriteLine("--Rever a string--");
    Console.WriteLine("Write a word:");
    var val = Console.ReadLine();
    if (val == null)
    { Console.WriteLine("Invalid word"); }
    else
    {
      var word = reverseWord(val);
      Console.WriteLine($"---> Here is the word reversed {word}<---");
    }
  }

  private static string reverseWord(string? val)
  {
    var pool = new List<char>();
    int length = val.Length;
    for (int i = 0; i < length; i++)
    {
      pool.Add(val[length - (1 + i)]);
    }
    return string.Join("", pool);
  }
}
