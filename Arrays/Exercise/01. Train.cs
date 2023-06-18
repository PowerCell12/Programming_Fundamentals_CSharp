using System;

partial class Program {
  public static void Main (string[] args) {

    int lines = int.Parse(Console.ReadLine());
    int[] wagons = new int[lines];

    for (int i = 0; i < lines; i++){


        wagons[i] = int.Parse(Console.ReadLine());
    }

    Console.WriteLine(string.Join(" ", wagons));
    Console.WriteLine(wagons.Sum());
  }
}
