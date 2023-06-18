using System;

partial class Program {
  public static void Main (string[] args) {


    int lines = int.Parse(Console.ReadLine());

    int[] array1 = new int[lines];
    int[] array2 = new int[lines];


    for (int i = 0; i < lines; i++) {
        int[] inputs = Console.ReadLine().Split().Select(int.Parse).ToArray();

        if (i % 2 == 0){
            array1[i] = inputs[0];
            array2[i] = inputs[1];
        }
        else {
            array1[i] = inputs[1];
            array2[i] = inputs[0];
        }
    }

    Console.WriteLine(string.Join(" ", array1));
    Console.WriteLine(string.Join(" ", array2));
  }
}
