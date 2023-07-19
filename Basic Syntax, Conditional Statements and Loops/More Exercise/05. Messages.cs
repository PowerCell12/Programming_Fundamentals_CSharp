using System;

class Program {
  public static void Main (string[] args) {
    int lines = int.Parse(Console.ReadLine());
    string letter = "";
    string final = "";
    
    for (int i = 0; i < lines; i++)
    {
      int numbers = int.Parse(Console.ReadLine());

      if (numbers == 2)
      {
        letter = "a";
      }
      else if (numbers == 22)
      {
        letter = "b";
      }
      else if (numbers == 222)
      {
        letter = "c";
      }
      else if (numbers == 3)
      {
        letter = "d";
      }
      else if (numbers == 33)
      {
        letter = "e";
      }
      else if (numbers == 333)
      {
        letter = "f";
      }
      else if (numbers == 4)
      {
        letter = "g";
      }
      else if (numbers == 44)
      {
        letter = "h";
      }
      else if (numbers == 444)
      {
        letter = "i";
      }
      else if (numbers == 5)
      {
        letter = "j";
      }
      else if (numbers == 55)
      {
        letter = "k";
      }
      else if (numbers == 555)
      {
        letter = "l";
      }
      else if (numbers == 6)
      {
        letter = "m";
      }
      else if (numbers == 66)
      {
        letter = "n";
      }
      else if (numbers == 666)
      {
        letter = "o";
      }
      else if (numbers == 7)
      {
        letter = "p";
      }
      else if (numbers == 77)
      {
        letter = "q";
      }
      else if (numbers == 777)
      {
        letter = "r";
      }
      else if (numbers == 7777)
      {
        letter = "s";
      }
      else if (numbers == 8)
      {
        letter = "t";
      }
      else if (numbers == 88)
      {
        letter = "u";
      }
      else if (numbers == 888)
      {
        letter = "v";
      }
      else if (numbers == 9)
      {
        letter = "w";
      }
      else if (numbers == 99)
      {
        letter = "x";
      }
      else if (numbers == 999)
      {
        letter = "y";
      }
      else if (numbers == 9999)
      {
        letter = "z";
      }
      else if (numbers == 0)
      {
        letter = " ";
      }

      final += letter; 
    }
    Console.WriteLine(final);
  }
}
