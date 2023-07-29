using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program {
  public static void Main (string[] args) {

    string text = Console.ReadLine();
    string pattern = @"\+359( |-)2\1[0-9]{3}\1[0-9]{4}\b";
    Regex regex = new Regex(pattern);  


    MatchCollection final =  regex.Matches(text);
    List<Match> list = new List<Match>();

    foreach(Match final1 in final){
      list.Add(final1);
    }

    Console.WriteLine(string.Join(", ", list));    
  }
}
