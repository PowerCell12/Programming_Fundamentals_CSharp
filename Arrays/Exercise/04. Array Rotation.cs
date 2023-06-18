using System;

partial class Program {
  public static void Main (string[] args) {


    int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int lines = int.Parse(Console.ReadLine());


    for (int i = 0; i < lines; i++) {

        for (int j = 0; j < array.Length - 1; j++) {
            int the_next = array[j]; 

            array[j]  = array[j + 1];
            array[j + 1] = the_next;
        }
    }
 
    Console.WriteLine(string.Join(" ", array));

    }
}
