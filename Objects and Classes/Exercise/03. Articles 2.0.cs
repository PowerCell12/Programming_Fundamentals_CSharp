using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

class Program {
  public static void Main (string[] args) {

      
    int NumberCommands = int.Parse(Console.ReadLine());
    List<Article> all = new List<Article>();
    
    for (int i = 0; i < NumberCommands; i++){
  
      List<string> Command = Console.ReadLine().Split(", ").ToList();

      Article article  = new Article(Command[0], Command[1], Command[2]);

      all.Add(article);
    }

    foreach(Article articlefinal in all){
      Console.WriteLine($"{articlefinal.Title} - {articlefinal.Content}: {articlefinal.Author}");
    }
      
    
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

