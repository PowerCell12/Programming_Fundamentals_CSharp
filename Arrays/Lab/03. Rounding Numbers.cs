using System;

class Program {
  public static void Main (string[] args) {

    string[] array_strings = Console.ReadLine().Split();

    double[] array_integers = new double[array_strings.Length];

    for (int i = 0; i < array_integers.Length; i++)
    {
      array_integers[i] = Convert.ToDouble(array_strings[i]);
    }

    for (int i = 0; i < array_integers.Length; i++){

      
      double final = Math.Round(array_integers[i], MidpointRounding.AwayFromZero);

      if (final == -0)
      {
          final = 0;
          Console.WriteLine($"{array_integers[i]} => {final}");
      }
      else
      {
        Console.WriteLine($"{array_integers[i]} => {final}");
      } 
    
    }
  }
}
