using System;

partial class Program {  
  public static void Main (string[] args) {    


    int integer1 = int.Parse(Console.ReadLine());
    int integer2 = int.Parse(Console.ReadLine());
    int integer3 = int.Parse(Console.ReadLine());

    int sumoftwo  = TheSum(integer1, integer2);
    int final  = TheFinal(sumoftwo, integer3);

    Console.WriteLine(final);
  }



  static int TheSum(int integer1, int integer2){

    return integer1 + integer2;

  }


  static int TheFinal(int sumoftwo, int integer3){

    return sumoftwo - integer3;

  }

}
