using System;

class Program {
  public static void Main (string[] args) {
    int lines = int.Parse(Console.ReadLine());
int all = 0;

for (int i = 0; i < lines; i++)
{
    char letters = char.Parse(Console.ReadLine());

    int letter1 = Convert.ToInt32(letters);

    all += letter1;
}


Console.WriteLine($"The sum equals: {all}");
  }
}
