using System;
using System.Text.RegularExpressions;

class Program {
  public static void Main (string[] args) {   


    List<int> ints = Console.ReadLine().Split().Select(int.Parse).ToList();


    string words = Console.ReadLine();

    foreach (int number in ints){


      int index = number.ToString().Select(digit => int.Parse(digit.ToString())).ToArray().Sum();


      int count = 0;


      for (int i = 0; i < words.Length; i++){

        count++;

        if (count == index){
          Console.Write(words[i + 1]);
          words = words.Remove(i, 1);
          break;
        }

        if (i + 1 == words.Length){

          i  = -1;

        }


      }



    }



  }
}
