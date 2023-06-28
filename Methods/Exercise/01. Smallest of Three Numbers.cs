using System;
partial class Program {  
  public static void Main (string[] args) {    

    int number1 = int.Parse(Console.ReadLine());
    int number2 = int.Parse(Console.ReadLine());
    int number3 = int.Parse(Console.ReadLine());


    int smallest2 = smallest1(number1, number2, number3); 

    

    Console.WriteLine(smallest2);
    
    }


    static int smallest1(int number1, int number2, int number3){


        if (number1   < number2 && number1 < number3){
            return number1;
        }
        if (number2 < number3 && number2 < number1){
            return number2;
        }
        if (number3 < number1 && number3 < number2){
            return number3;
        }

        return number1;

    }

  }
