using System;
partial class Program {  
  public static void Main (string[] args)
    {


      List<double> numbers  = Console.ReadLine().Split().Select(double.Parse).ToList();
      List<double> numbers_final = new List<double>();
      int counter = 1; 

      for (int i = 0; i < numbers.Count / 2; i++){
        numbers_final.Add(numbers[i] + numbers[numbers.Count - counter]);
        counter += 1;

    

      }


    if (numbers.Count % 2 != 0){
      int middle = numbers.Count / 2;
      numbers_final.Add(numbers[middle]);
    }

    Console.WriteLine(string.Join(" ", numbers_final));


    }

}
