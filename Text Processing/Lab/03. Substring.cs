using System;
using System.Collections.Generic;
using System.Linq;

class Program {
  public static void Main (string[] args) {

      
    string word = Console.ReadLine();
    string sequence = Console.ReadLine();

    while(true){

      int index = sequence.IndexOf(word);

      if(index == -1){
        break;
      }

      sequence = sequence.Remove(index, word.Length);


    }


    Console.WriteLine(sequence);


  }
}
