using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program {
  public static void Main (string[] args) {

    Dictionary<string, int> end  = new Dictionary<string, int>();
    List<string> participants = Console.ReadLine().Split(", ").ToList();

    while (true){

      string info = Console.ReadLine();

      if (info == "end of race"){
        break;
      }

      string pattern = @"(?<name>[a-zA-Z]+)";
      Regex regex = new Regex(pattern);


      MatchCollection final = regex.Matches(info);


      string name = " ";
      foreach(Match final1 in final){

        if (final1.Groups["name"].Value != ""){
          name += final1.Groups["name"].Value;
        }
        
      }

      string pattern1 = @"(?<price>\d)";
      Regex regex1 = new Regex(pattern1);
      MatchCollection matches1 = regex1.Matches(info);

      int score = 0;
      foreach(Match final2 in matches1){

       if (final2.Groups["price"].Value != ""){
          score += int.Parse(final2.Groups["price"].Value);
       }        
        
      }
      
      name = name.Replace(" ", "");
      if (participants.Contains(name)){
        if (!end.ContainsKey(name)){

          end[name] = score;
        
        }
        else{
          end[name] += score;
        }
      }
    }
    

      end = end.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
      int count = 1;
      foreach(KeyValuePair<string, int> pair in end){
        if (count == 4){
          break;
        }
        if (count == 1){
            Console.WriteLine($"{count}st place: {pair.Key}");
        }
        else if (count == 2){
            Console.WriteLine($"{count}nd place: {pair.Key}");
        }
        else if (count == 3){
          Console.WriteLine($"{count}rd place: {pair.Key}");
        }
        count++;
      }
    
    
  }
}
