using System;

partial class Program {
  public static void Main (string[] args) {

    string[] string1 = Console.ReadLine().Split();
    string[] string2 = Console.ReadLine().Split();
    int  counter = 0;


    string[] inBoth = new string[string2.Length];


    for (int i = 0; i < string2.Length; i++) {
        

        if (string1.Contains(string2[i])) {
            inBoth[counter] += string2[i];

            counter += 1;
        }
    }

    Console.WriteLine(string.Join(" ", inBoth));


  }
}
