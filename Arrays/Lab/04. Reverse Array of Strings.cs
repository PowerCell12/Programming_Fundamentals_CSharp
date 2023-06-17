using System;


partial class Program {
  public static void Main (string[] args) {

    string[] hello = Console.ReadLine().Split();

    Array.Reverse(hello);
    
    for (int i = 0; i < hello.Length; i++)
    {
      Console.Write($"{hello[i]}" + " "); 
    }
  }
} 
