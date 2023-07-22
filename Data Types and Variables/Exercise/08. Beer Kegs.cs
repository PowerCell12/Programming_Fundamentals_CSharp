using System;

class Program {
  public static void Main (string[] args) {
    int lines = int.Parse(Console.ReadLine());
    double formula = 0;
    double biggest = 0;
    string name = "";
    
    for (int i = 0; i < lines; i++)
    {
      string model = Console.ReadLine();
      double  radius = double.Parse(Console.ReadLine());
      int height = int.Parse(Console.ReadLine());

      formula = Math.PI * Math.Pow(radius, 2) * height;

      if (formula > biggest)
      {
        biggest = formula;
        name = model;
      }
    }
    Console.WriteLine(name);
    
  }
}
