using System;

class Program {
  public static void Main (string[] args) {

    string strings = Console.ReadLine();
    string final = "";
    
    for (int i = 0; i < strings.Length; i++){

      if(i != 0 && strings[i - 1] != strings[i]){
        final += strings[i];
      }
      if (i == 0){
       final += strings[i]; 
      }
      
    }

    Console.WriteLine(final);
    
  }
}
