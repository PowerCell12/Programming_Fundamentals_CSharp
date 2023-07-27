using System;


class Program {
  public static void Main (string[] args) {  

    string title = Console.ReadLine();
    string content = Console.ReadLine();
    List<string> comments = new List<string>();

    while (true){

      string words = Console.ReadLine();

      if (words == "end of comments"){
        break;
      }

      comments.Add(words);
    }

    Console.WriteLine($"<h1>\n  {title}\n</h1>");
    Console.WriteLine($"<article>\n  {content}\n</article>");

    foreach(var thing in comments){

      Console.WriteLine($"<div>\n   {thing}\n</div>");

    }



  }
}
