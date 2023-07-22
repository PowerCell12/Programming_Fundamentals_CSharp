using System;

class Program {
  public static void Main (string[] args) {
    int spices = int.Parse(Console.ReadLine());
    int extracted = 0;
    int days = 0;
    
    while (true)
    {

      if (spices < 100) // if the yielf is below 100, break
      {
        if (extracted - 26 < 0)
        {
          extracted = 0;
        }
        else
        {
          extracted = extracted - 26;
        }
        Console.WriteLine(days);
        Console.WriteLine(extracted);
        break;
      }
      
      extracted += spices;
      days++;

      if (extracted - 26 < 0) // check if there is enough spice, if not the spice is equall to 0
      {
        extracted = 0;
      }
      else
      {
      extracted -= 26; // spice for workers
      }
      
      spices = spices - 10; // the yield drop by 10 every day
    }   
  }
}
