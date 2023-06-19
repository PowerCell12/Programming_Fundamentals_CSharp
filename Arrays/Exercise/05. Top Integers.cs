using System;
partial class Program {
  public static void Main (string[] args) {

    int[] integers = Console.ReadLine().Split().Select(int.Parse).ToArray();
    string[] integers_top = new string[integers.Length];
    bool bool1 = true;
    int counter = 0;
    
    for (int i = 0; i < integers.Length; i++){

      for (int j = i  + 1; j < integers.Length; j++){
        
        if (integers[i] > integers[j]){
          continue;
        }
        else {
          bool1 = false;
          break;
        }
      }

      if (bool1 == true){
        integers_top[counter] = Convert.ToString(integers[i]);
        counter += 1;
      }  


      bool1 = true;
    }

    foreach (var things in integers_top){
        Console.Write($"{things}"  + " ");
      }
    }
    
}
