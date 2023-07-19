using System;
using System.Text.RegularExpressions;

class Program {
  public static void Main (string[] args) {

    List<int> numbers = new List<int> ();

    numbers.Add(int.Parse(Console.ReadLine()));
    numbers.Add(int.Parse(Console.ReadLine()));
    numbers.Add(int.Parse(Console.ReadLine()));

    numbers.Sort();
    numbers.Reverse();

    foreach( int number in numbers ){
      Console.WriteLine(number);
    }



  }
}
