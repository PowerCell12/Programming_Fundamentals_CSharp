using System;

class Program {
  public static void Main (string[] args) {
    int people = int.Parse(Console.ReadLine());
int capacity = int.Parse(Console.ReadLine());

int final = people / capacity;

if (people % capacity != 0)
{
    int final1 = final + 1;
    Console.WriteLine(final1);
}
else
{
    Console.WriteLine(final);
}


  }
}
