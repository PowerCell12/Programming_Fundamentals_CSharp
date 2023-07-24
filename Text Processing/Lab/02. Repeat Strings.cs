using System;
using System.Collections.Generic;
using System.Linq;

class Program {
  public static void Main (string[] args) {


    string[] words = Console.ReadLine().Split().ToArray();
    string new_string = "";

    foreach (string word in words) {

      int lengths = word.Length;


      for (int i = 0; i < lengths; i++) {

        new_string += word;

      }



    }

    Console.WriteLine(new_string);



  }
}
