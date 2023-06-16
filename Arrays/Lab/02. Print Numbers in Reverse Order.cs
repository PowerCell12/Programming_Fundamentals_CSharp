using System;

partial class Program {
  public static void Main (string[] args) {
    
    int lines = int.Parse(Console.ReadLine());
    int[] numbers = new int[lines];

    for (int i = 0; i < lines; i++) {

      int number  = int.Parse(Console.ReadLine());
      numbers[i] = number;
    }

    Array.Reverse(numbers);

    for (int i = 0; i < numbers.Length; i++) {
      Console.Write(numbers[i]);
      Console.Write(" ");
    }
  }
}
