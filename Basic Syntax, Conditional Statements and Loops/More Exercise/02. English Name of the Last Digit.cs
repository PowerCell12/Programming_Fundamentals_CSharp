using System;
using System.Text.RegularExpressions;

class Program {
  public static void Main (string[] args) {


  Dictionary<int, string> dictionary = new Dictionary<int, string>()  
  { 
    { 0, "zero"},
    { 1, "one" },
    { 2, "two" },
    { 3, "three" },
    { 4, "four" },
    { 5, "five" },
    { 6, "six" },
    { 7, "seven" },
    { 8, "eight" },
    { 9, "nine" }
  };

  string number = Console.ReadLine();

  char last = number[number.Length - 1];
  int last1 = (int)last - '0';


  Console.WriteLine(dictionary[last1]);

  }
}
