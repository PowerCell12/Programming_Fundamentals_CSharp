using System;

class Program {
  public static void Main (string[] args) {
    int capacity = 255;
    int lines = int.Parse(Console.ReadLine());
    int capacity1 = 0;
    
    for (int i = 0; i < lines; i++)
    {
      int ToPour = int.Parse(Console.ReadLine());

      if (capacity - ToPour >= 0)
      {
        capacity1 += ToPour;
        capacity = capacity - ToPour;
      }
      else
      {
        Console.WriteLine("Insufficient capacity!");
        continue;
      }
    }
    Console.WriteLine(capacity1);
  }
}
