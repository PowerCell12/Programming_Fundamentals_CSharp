using System;

class Program {
  public static void Main (string[] args) {
    int day = int.Parse(Console.ReadLine());

string[] Days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

day =  day - 1;

if (-1 < day && day < 7)
{
    Console.WriteLine(Days[day]);
}
else
{
    Console.WriteLine("Invalid day!");
}
  }
}
