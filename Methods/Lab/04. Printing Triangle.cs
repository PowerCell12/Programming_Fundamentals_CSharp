using System;

class Program {
  public static void Main (string[] args) {

    int length1 = int.Parse(Console.ReadLine());
    int tostart = 0;
    
    for (int i = 1; i <= length1; i++){

      if (i == 1){
        Console.Write(i);
      }
      else{
          Console.WriteLine(""); 
          for (int j = 1; j <= i; j++){
            Console.Write($"{j} ");
          }
      }
      tostart = i;
    }

    for (int k = tostart - 1; k > 0; k--){

      Console.WriteLine("");
      for (int p = 1; p <= k; p++){
        Console.Write($"{p} ");
      } 
    }
    
  }
}
