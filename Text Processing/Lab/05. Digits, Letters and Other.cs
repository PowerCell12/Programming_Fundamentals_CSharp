using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {

    string strings = Console.ReadLine();
    string numbers = "";
    string letters = "";
    string character  = "";

    
    foreach(char a in strings)  {

      if (Char.IsDigit(a)){
        numbers += a;
      }
      else if (Char.IsLetter(a)){
        letters += a;
        
      }
      else {
        character += a;
      }
      }


      Console.WriteLine(numbers);
      Console.WriteLine(letters);
      Console.WriteLine(character);
    
  }
}
