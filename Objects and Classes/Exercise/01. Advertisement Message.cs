using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
  
      List<string> phrases = new List<string>() {"Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product."};

      List<string> events = new List<string>() {"Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"};

      List<string> authors = new List<string>() {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};

      List<string> cities = new List<string>() {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};


      Random rnd = new Random();


      int lines = int.Parse(Console.ReadLine());

      for (int i = 0; i < lines; i++){
  
        string phrase_final = phrases[rnd.Next(0, phrases.Count)];
        string event_final = events[rnd.Next(0, events.Count)];
        string author_final = authors[rnd.Next(0, authors.Count)];
        string city_final = cities[rnd.Next(0, cities.Count)];
        Console.WriteLine($"{phrase_final} {event_final} {author_final} – {city_final}.");
      }

        
    }
}
