using System;
using System.Text.RegularExpressions;

class Program {
  public static void Main (string[] args) {   
    

    int to_move = int.Parse(Console.ReadLine());


    int how_many =  int.Parse(Console.ReadLine());

    List<char> list = new List<char>();

    for (int i = 0; i < how_many; i++){

      char letter = char.Parse(Console.ReadLine());


      list.Add(letter);
    }

    List<char> list2 = new List<char>();

    foreach(char j in list){

     int asciiValue = (int)j;
    // Modify the ASCII value here
     char modifiedChar = (char)(asciiValue + to_move);

      list2.Add(modifiedChar);

    }

    Console.WriteLine(string.Join("", list2));




  }
}
