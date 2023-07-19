using System;

class Program {
  public static void Main (string[] args) {
    string normal = Console.ReadLine();
    string reversed = "";
    
    for (int i = normal.Length -1; i >= 0; i--)
    {
      reversed += normal[i];
    }
    Console.WriteLine(reversed);
  }
}
