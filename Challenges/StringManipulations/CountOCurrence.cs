namespace CodeChallenges;

public static class CountOCurrence
{
  public static void Display()
  {
    Console.WriteLine("--Counts the number of occurrences of each character--");
    Console.WriteLine("Write a word:");
    var val = Console.ReadLine();
    if (val == null)
    { Console.WriteLine("Invalid word"); }
    else
    {
      var store = CountOccurrences(val);
      Console.WriteLine($"---> Here are the results:");
      foreach (var key in store.Keys)
      {
        Console.WriteLine($"\t -> {key}: {store[key]}");
      }
    }
  }

  private static Dictionary<char, int> CountOccurrences(string val)
  {
    var store = new Dictionary<char, int>();
    var listCharacters = val.ToCharArray();
    foreach (var item in listCharacters)
    {
      var exists = store.ContainsKey(item);
      if (exists)
      {
        var value = store[item];
        store[item] = value + 1;
      }
      else
      {
        store.Add(item, 1);
      }
    }
    return store;
  }
}
