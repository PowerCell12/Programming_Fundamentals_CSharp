using System;
using System.Text.RegularExpressions;

class Program {
  public static void Main (string[] args) {

    string words = Console.ReadLine();
    string pattern = @"\b[A-Z][a-z]{1,} [A-Z][a-z]{1,}\b";
    Regex regex = new Regex(pattern);

    MatchCollection final = regex.Matches(words);

    foreach(Match final1 in final){
      Console.Write(final1 + " ");
    }

    
    
      
  }
}
