using System;

class Program {
  public static void Main (string[] args) {
    string integer = Console.ReadLine();
int all = 0;

for (int i = 0; i < integer.Length; i++)
{
    char all1 = integer[i];
    int all2 = all1 - '0';
    all += all2;
}

Console.WriteLine(all);
  }
}
