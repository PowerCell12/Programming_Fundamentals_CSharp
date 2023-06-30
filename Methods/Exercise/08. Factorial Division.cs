using System;
using System.Text.RegularExpressions;

class Program {
  public static void Main (string[] args) {   


    int num1 = int.Parse(Console.ReadLine());
    int num2= int.Parse(Console.ReadLine());

    double final1 = factorial(num1);
    double final2 = factorial(num2);

    double final = final1 / final2;

    Console.WriteLine($"{final:F2}");

  }



static double factorial(int numbers){

    double final = 1;

    for (int i = 1; i <= numbers; i++){

      final *= i;
    }

    return final;
  

}


}
