using System;
partial class Program {  
  public static void Main (string[] args)
    {

      List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

      
      for (int i = 0; i < numbers.Count; i++){

        if (numbers[i] < 0){

          numbers.RemoveAt(i); 
          i -= 1;
        }
      }


      if (numbers.Count == 0){
        Console.WriteLine("empty");
      }
      else{

        numbers.Reverse();

        Console.WriteLine(string.Join(" ", numbers));
      }

    }

}
