int integer = int.Parse(Console.ReadLine());
string number1 = integer.ToString();
int all = 1;
int all1 = 0;

for (int i = 0; i < number1.Length; i++)
{
  char one = number1[i];
  int one1  = one - '0';

  for (int j = 1; j <= one1; j++)
  {
    all = all * j;
  }
  all1 += all;

  all = 1;
}

if (all1 == integer)
{
  Console.WriteLine("yes");
}
else
{
  Console.WriteLine("no");
}
