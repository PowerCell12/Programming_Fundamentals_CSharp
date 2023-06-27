using System;

class Program {
  public static void Main (string[] args) {


    double base_first = double.Parse(Console.ReadLine());
    int power = int.Parse(Console.ReadLine());

    ToThePower(base_first, power);
  
    
    static void ToThePower(double base_first, int power){
      double second = base_first;
      
      for (int i = 0; i < power - 1; i++){
        base_first *= second;  
      }

      Console.WriteLine(base_first);
      
    }

    
  }
}
