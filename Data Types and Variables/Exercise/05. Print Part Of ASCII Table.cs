using System;

class Program {
  public static void Main (string[] args) {
    int startPoints = int.Parse(Console.ReadLine());
int endPoints = int.Parse(Console.ReadLine());


for (int i = startPoints; i <= endPoints; i++)
{
    char final1 = Convert.ToChar(i);

    Console.Write(final1);
    Console.Write(" ");
}
  }
}
