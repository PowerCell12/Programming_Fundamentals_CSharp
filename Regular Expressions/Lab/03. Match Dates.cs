using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

class Program {
  public static void Main (string[] args) {

    string text = Console.ReadLine();
    string pattern = @"(?<date>[0-9]{2})(\/|\-|\.)(?<month>[A-Z][a-z]{2})\1(?<year>[0-9]{4})";
    Regex regex = new Regex(pattern);

    MatchCollection final = regex.Matches(text);
    List<Match> final1 = new List<Match>();

    foreach(Match final2 in final){

      Console.WriteLine($"Day: {final2.Groups["date"].Value}, Month: {final2.Groups["month"].Value}, Year: {final2.Groups["year"].Value}");
      
    }

    
  }
}
