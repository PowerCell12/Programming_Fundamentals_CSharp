using System;


class Program {
  public static void Main (string[] args) {   


    int start = (int)char.Parse(Console.ReadLine());
    int end = (int)char.Parse(Console.ReadLine());
    string final = Console.ReadLine();
    double total = 0 ;

    foreach(var f in final){

      int now = (int)f;

      if (now < end && now > start){
        total += now;
      }
    }

    Console.WriteLine(total);






  }
}
