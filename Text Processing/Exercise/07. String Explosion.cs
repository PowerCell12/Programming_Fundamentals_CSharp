using System;


class Program {
  public static void Main (string[] args) {   


    string message = Console.ReadLine();
    int power_needed = 0;
    string final_str  = "";

    for (int i = 0; i < message.Length; i++){
      char mess = message[i];

      if (mess == '>'){

        power_needed += Convert.ToInt32(Char.GetNumericValue(message[i + 1]));
        final_str += mess;

      }
      else if (power_needed == 0){
        final_str += mess;
      }
      else{
        power_needed--;
      }
    }

    Console.WriteLine(final_str);


  }
}
