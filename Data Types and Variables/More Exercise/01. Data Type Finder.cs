using System;

class Program {
  public static void Main (string[] args) {
    int n;
    float b;
    char c;
    bool d;
    
    while (true)
    {
      string  type = Console.ReadLine();
      bool isBoolean = bool.TryParse(type, out d);
      bool isCharacter = char.TryParse(type, out c);
      bool IsFloting = float.TryParse(type, out b);
      bool isNumeric = int.TryParse(type, out n);

      
      if (type == "END")
      {
        break;
      }
      
      if (isNumeric == true)
      {
        Console.WriteLine($"{type} is integer type");
      }
      else if  (IsFloting == true)
      {
        Console.WriteLine($"{type} is floating point type");
      }
      else if (isCharacter == true)
      {
        Console.WriteLine($"{type} is character type");
      }
      else if (isBoolean == true)
      {
        Console.WriteLine($"{type} is boolean type");
      }
      else
      {
        Console.WriteLine($"{type} is string type");
      }
    }
  }
}
