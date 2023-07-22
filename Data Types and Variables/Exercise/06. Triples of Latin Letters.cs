using System;

class Program {
  public static void Main (string[] args) {
    int letters = int.Parse(Console.ReadLine());

for (int i = 0; i < letters; i++)
{

    for (int j = 0; j < letters; j++)
    {

        for (int k = 0; k < letters; k++)
        {

            char first = (char) ('a'  + i);
            char second = (char) ('a' + j);
            char third = (char) ('a' + k);
            Console.WriteLine($"{first}{second}{third}");
        }
    }
}

  }
}
