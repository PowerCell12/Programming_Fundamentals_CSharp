using System;

partial class Program {
  public static void Main (string[] args) {

    int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
    bool bool1 = true;


    while (bool1){

      if (numbers.Length == 1){
          bool1 = false;
          Console.WriteLine(numbers[0]);
          continue;
      }


      int[] condensed = new int[numbers.Length - 1];


      for (int i = 0; i < numbers.Length - 1; i++){
        condensed[i] = numbers[i] + numbers[i + 1];
      }

      numbers = condensed;
    }
  

  }
}
