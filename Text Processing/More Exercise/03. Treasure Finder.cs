using System;


class Program {
  public static void Main (string[] args) {   


    List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();


    while (true){

      string final  =Console.ReadLine();

      if (final == "find"){
        break;
      }

      string new_string = "";
      int count = 0;

      foreach(char c in final){

        int asscci  = (int)c;
        
        char new_char = (char)((char)asscci  - numbers[count]);

        new_string += new_char;
        count++;
        if (count == numbers.Count){
          count = 0;
        }


      }

      int firstindex = new_string.IndexOf("&");
      int firstindexsecod = new_string.LastIndexOf("&");
      int lastindex = new_string.IndexOf("<");
      int lastindexsecond = new_string.IndexOf(">");


      string type = new_string.Substring(firstindex + 1, firstindexsecod - firstindex - 1);
      string coordinates = new_string.Substring(lastindex + 1, lastindexsecond - lastindex - 1);

      Console.WriteLine($"Found {type} at {coordinates}");

    }





  }
}
