using System;


class Program {
  public static void Main (string[] args) {   


    int lines = int.Parse(Console.ReadLine());

    for (int i = 0; i < lines; i++){

      string final = Console.ReadLine();
      string name = "";
      string age = "";

      int indexfirst = final.IndexOf("@");
      int indexfirstsecond = final.IndexOf("|");
      int indexsecond = final.IndexOf("#");
      int indexsecondsecond = final.IndexOf("*");

      name = final.Substring(indexfirst + 1, indexfirstsecond - indexfirst - 1);
      age = final.Substring(indexsecond + 1, indexsecondsecond - indexsecond - 1);




      Console.WriteLine($"{name} is {age} years old.");
    }





  }
}
