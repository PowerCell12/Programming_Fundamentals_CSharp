using System;

partial class Program {
  public static void Main (string[] args) {


    List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();
    double time1 = 0;
    double time2 = 0;


    for (int i  = 0; i < numbers.Count / 2;  i++) {

      if (numbers[i] == 0) {

        time1 = time1 * 0.8;
        continue;
      }

      time1 += numbers[i];
    }


    for (int i  = numbers.Count / 2  + 1; i < numbers.Count;  i++) {

      if (numbers[i] == 0) {

        time2 = time2 * 0.8;
        continue;
      }

      time2 += numbers[i];
    }

// if error maybe equal
    if (time1 < time2) {

      Console.WriteLine($"The winner is left with total time: {time1}");
    }
    else {
      Console.WriteLine($"The winner is right with total time: {time2}");
    }


    
  }
}
