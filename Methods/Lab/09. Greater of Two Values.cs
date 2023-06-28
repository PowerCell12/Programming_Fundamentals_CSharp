using System;
class Program {  
  public static void Main (string[] args) {    
    string type = Console.ReadLine();    
    if (type == "int"){      
      int number1 = int.Parse(Console.ReadLine());      
      int number2 = int.Parse(Console.ReadLine());      
      int final = GetMax(number1, number2);  
      Console.WriteLine(final);
    }    
    if (type == "char"){      
      char char1 = char.Parse(Console.ReadLine());      
      char char2 = char.Parse(Console.ReadLine());      
      char final = GetMax(char1, char2); 
      Console.WriteLine(final); 
    }        
    if (type == "string"){
      string string1 = Console.ReadLine();
      string string2 = Console.ReadLine();
      string final = GetMax(string1, string2);
      Console.WriteLine(final);
    }
  } 
  
  static int GetMax(int number1, int number2){      
    if (number1 > number2){        
      return number1;      
    }      
    return number2;    
  }    
    
  static char GetMax(char char1, char char2){      
    if (char1 > char2){        
      return char1;      
    }      
    return char2;    
  }      

  static string GetMax(string string1, string string2){

        if (String.Compare(string1, string2) < 0)
            return string2;
        
        else if (String.Compare(string1, string2) > 0)
           return string1;    

        return string1;
  }
}
