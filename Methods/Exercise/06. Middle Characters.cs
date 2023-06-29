using System;

partial class Program {  
  public static void Main (string[] args) {    

    string chracters = Console.ReadLine();

    string middle = MiddleCharacters(chracters);

    Console.WriteLine(middle);

  }

  static string MiddleCharacters(string chracters){

    int middle  = (int)chracters.Length / 2;

    if (chracters.Length % 2 != 0){
      
      for (int i = 0; i < chracters.Length; i++){

        if (i == middle) {
          return Convert.ToString(chracters[i]);
        }
      }
    }
    else{
      string middles = null;

      for (int i = 0; i < chracters.Length; i++){

        if (i == middle - 1 || i == middle){

          middles += Convert.ToString(chracters[i]);

        }
      }

      return middles;

    }

    return null;

  }

}
