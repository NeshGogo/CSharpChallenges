namespace CodeChallenges;

public static class Menu
{
  private static string[] options = new string[]{
      "Checks if a string is a palindrome (reads the same forwards and backwards).",
      "reverses a string",
      "Exit."
    };

  public static void PrintMenu()
  {
    Console.WriteLine("--- Menu ---");
    Console.WriteLine("Select an option:");
    int length = options.Length;
    for (int i = 0; i < length; i++)
    {
      Console.WriteLine($"{i+1} - {options[i]}");
    }
  }


  public static void SelectOption(){
    Console.WriteLine("Please enter the option:");
    var option = Console.ReadLine();
    int.TryParse(option, out int val);
    switch (val)
    {
      case (int)MenuOptions.CheckPalindrom + 1:
        CheckPalindrome.Display();
      break;
      case (int)MenuOptions.ReverseString + 1:
        StringReverser.Display();
      break;
      case (int)MenuOptions.Exit + 1:
        Console.WriteLine("Goodbye!!!");
      break;
      default:
        Console.WriteLine("It's an invalid character.");
        Console.ReadKey();
      break;
    }
  }

}
