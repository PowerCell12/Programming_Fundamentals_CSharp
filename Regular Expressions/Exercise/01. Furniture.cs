using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program {
  public static void Main (string[] args) {


    List<Match> final = new List<Match>();

    while (true){
      string text = Console.ReadLine();

      if (text == "Purchase"){
        break;
      }

      string pattern  = @">>(?<name>[a-zA-Z]+)<<(?<price>[0-9]+|[0-9]+\.[0-9]+)!(?<quantity>[0-9]+)";

      Regex regex = new Regex(pattern);
    

      Match matches = regex.Match(text);


      final.Add(matches);
      }

      
    double totalprice  = 0;
  
    Console.WriteLine($"Bought furniture:");

    foreach(Match match in final){
      if (match.Groups["price"].Value != ""){
        Console.WriteLine(match.Groups["name"].Value);
        totalprice += Convert.ToDouble(match.Groups["price"].Value) * Convert.ToDouble(match.Groups["quantity"].Value);
      }
    }

    Console.WriteLine($"Total money spend: {totalprice:F2}");


  }
}
