using System;

class Program {
  public static void Main (string[] args) {

    string strings = Console.ReadLine();
    int number = int.Parse(Console.ReadLine());

    Repeat(strings, number);
    
    
    static void Repeat(string strings, int number){
      string old_strings = strings;
      
      for (int i = 0; i  < number - 1; i++){
        strings += old_strings;
      }
      Console.WriteLine(strings);
    }

    
  }
}
