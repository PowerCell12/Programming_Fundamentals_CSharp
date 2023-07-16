using System;
using System.Collections.Generic;
using System.Linq;

class Program {
  public static void Main (string[] args) {

    

    Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

    int count = int.Parse(Console.ReadLine());


    for (int i = 0; i < count; i++) {

      string word = Console.ReadLine();
      string synonym = Console.ReadLine();

      if (dictionary.ContainsKey(word)){
        dictionary[word].Add(synonym);
      }
      else{
        dictionary[word] = new List<string>();
        dictionary[word].Add(synonym);
      }
    }


    foreach (KeyValuePair<string, List<string>> pair in dictionary){
      Console.WriteLine($"{pair.Key} - {string.Join(", ", pair.Value)}");
    }

  }
}


