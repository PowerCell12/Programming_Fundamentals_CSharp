using System;

class Program {
  public static void Main (string[] args) {
    int number1 =  int.Parse(Console.ReadLine());
    int number2  = int.Parse(Console.ReadLine());
    Area(number1, number2);
  
    static void Area(int number1, int number2){
      Console.WriteLine($"{number1  * number2}");
    }
  }
}
