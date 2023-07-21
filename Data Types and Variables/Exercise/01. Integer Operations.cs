using System;

class Program {
  public static void Main (string[] args) {
    int first = int.Parse(Console.ReadLine());
int second = int.Parse(Console.ReadLine());
int third = int.Parse(Console.ReadLine()); 
int fourth = int.Parse(Console.ReadLine());

int final = first + second;

int final1 = final / third;

int final2 = final1 * fourth;

Console.WriteLine(final2);
  }
}
