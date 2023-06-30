using System;
partial class Program {  
  public static void Main (string[] args) {    




    while (true) {

      string numbers  = Console.ReadLine();

      if (numbers == "END"){
        break;
      }


      bool YesNo =  Palidrome(numbers);

      if (YesNo == true) {
        Console.WriteLine("true");
      }
      else{
        Console.WriteLine("false");
      }

    }


    static bool Palidrome(string numbers){
      string new_string = null;


      for (int i = numbers.Length - 1; i >= 0; i--) {

        new_string += numbers[i];

      }

      if (numbers == new_string){
        return true;
      }
      else{
        return false;
      }


    }



  }
}
