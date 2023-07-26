using System;
using System.Numerics;


class Program {
  public static void Main (string[] args) {

    BigInteger number = BigInteger.Parse(Console.ReadLine());

    int digit = int.Parse(Console.ReadLine());

    Console.WriteLine(number * digit);

    
    
  }
}
