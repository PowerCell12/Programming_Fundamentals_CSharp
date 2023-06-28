using System;
partial class Program {  
  public static void Main (string[] args) {    

    double number1 = double.Parse(Console.ReadLine());
    string operator1  = Console.ReadLine();
    double number2 = double.Parse(Console.ReadLine());

    if (operator1 == "+"){
        Console.WriteLine(Plus(number1, number2));
    }
    else if  (operator1 == "-"){
        Console.WriteLine(Minus(number1, number2));
    }
    else if (operator1 == "*"){
        Console.WriteLine(multiplication(number1, number2));
    }
    else if (operator1 == "/"){
        Console.WriteLine(division(number1, number2));
    }

    }
 
    static double Plus(double number1, double number2){

        double final  = number1 + number2;
        return final;
    }

    static double Minus(double number1, double number2){

        double final = number1 - number2;
        return final;
    }

    static double multiplication(double number1, double number2){
        
        double final = number1 * number2;
        return final;

    }

    static double division(double number1, double number2){

        double final = number1 / number2;
        return final;
    }

  }
