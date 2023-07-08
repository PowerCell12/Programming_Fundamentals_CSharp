using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

class Program {
  public static void Main (string[] args) {

    List<string> article  = Console.ReadLine().Split(", ").ToList();

    Article article_final = new Article(article[0], article[1], article[2]);
      
    int NumberCommands = int.Parse(Console.ReadLine());

    for (int i = 0; i < NumberCommands; i++){
  
      List<string> Command = Console.ReadLine().Split(": ").ToList();

      if (Command[0] == "Edit"){
        article_final.Edit(Command[1]);
      }
      else if (Command[0] == "ChangeAuthor"){
        article_final.ChangeAuthor(Command[1]);
      }
      else if (Command[0] == "Rename"){
        article_final.Rename(Command[1]);
      } 
    }

    Console.WriteLine($"{article_final.Title} - {article_final.Content}: {article_final.Author}");
    
    
  }
}



public class Article
{

  public string Title { set; get; }
  public string Content { set; get; }
  public string Author { set; get; }

  public Article(string title, string content, string author){
    Title = title;
    Content = content;
    Author = author;
  }


  public void Edit(string new_content){

      Content = new_content;
    
  }


  public void ChangeAuthor(string new_author){
    Author = new_author;
  }

  public void Rename(string new_title){
    Title = new_title;
  }

  public override string ToString()
  {
    
    return $"{Title} - {Content}: {Author}";
    
  }
}

