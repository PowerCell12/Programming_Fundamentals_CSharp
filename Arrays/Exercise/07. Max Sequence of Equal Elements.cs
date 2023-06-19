using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {

    int[] array1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
    int biggest = 0;
    string[] biggest_sequence = new string[array1.Length];
    
    for (int i = 0; i < array1.Length; i++){
      int counter = 0;
      string[] sequences = new string[array1.Length];

      
      for (int j = i; j < array1.Length; j++){

        if (array1[i] == array1[j]){
          sequences[counter] = Convert.ToString(array1[i]);
          counter +=1;
        }
        else{
          break;
        }      
      }

      if (counter > biggest){
        biggest = counter;
        biggest_sequence = sequences;
      }
      
    }


    Console.WriteLine(string.Join(" ", biggest_sequence));

    
  }
}
