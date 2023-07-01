using System;
partial class Program {  
  public static void Main (string[] args)
    {

      double num1 = double.Parse(Console.ReadLine());
      double num2 = double.Parse(Console.ReadLine());
      double num3 = double.Parse(Console.ReadLine());

      bool boolFinal = PosNeg(num1,num2,num3);

      if (num1 == 0 || num2 == 0 || num3 == 0){
        Console.WriteLine("zero");
      }
      else if (boolFinal == true){
        Console.WriteLine("positive");
      }
      else{
        Console.WriteLine("negative");
      }

    }


    static bool PosNeg(double num1, double num2, double num3){

      int counter = 0;

      if (num1 < 0){
        counter++;
      }

      if (num2 < 0){
        counter++;
      }


      if (num3 < 0){
        counter++;
      }


      if (counter % 2 == 0 ){
        return true;
      }
      else{
        return false;
      }
    }

}
