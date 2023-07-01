using System;
partial class Program {  
  public static void Main (string[] args)
    {


      List<double> numbers =  Console.ReadLine().Split(" ").Select(double.Parse).ToList();

      for (int i = 0; i < numbers.Count - 1; i++){

        if (numbers[i]  == numbers[i + 1]){
          double number1 = numbers[i];
          numbers.RemoveAt(i);
          double number2 = numbers[i];
          numbers.RemoveAt(i);
          numbers.Insert(i, number1 + number2);
          i = -1;  
        }



      }

      Console.WriteLine(string.Join(" ", numbers)); 

    }

}
