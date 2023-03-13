int first = int.Parse(Console.ReadLine());
int second = int.Parse(Console.ReadLine());
int all = 0;

for (int i = first; i <= second; i++)
{
  Console.Write(i);
  Console.Write(" ");
  all += i;
}

Console.WriteLine($"\nSum: {all}");
