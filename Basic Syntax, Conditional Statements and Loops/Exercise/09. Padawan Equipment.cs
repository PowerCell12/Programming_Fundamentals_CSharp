double money  = double.Parse(Console.ReadLine());
int numberStudents = int.Parse(Console.ReadLine());
double LightsaverOne = double.Parse(Console.ReadLine());
double robeOne = double.Parse(Console.ReadLine());
double beltOne = double.Parse(Console.ReadLine());
double money_toRemove = 0;

for (int i = 1; i <= numberStudents; i++)
{
    if (i % 6 == 0)
    {
        money_toRemove += beltOne;
    }
}

double final1 = numberStudents * 0.1;
double more1 = Math.Ceiling(final1);


double final = LightsaverOne * (numberStudents + more1) + robeOne * numberStudents + beltOne * numberStudents;
final  = final - money_toRemove;

if (final <= money)
{
  Console.WriteLine($"The money is enough - it would cost {final:F2}lv.");
}
else
{
  double final3 = money - final;
  final3 = Math.Abs(final3);
  Console.WriteLine($"John will need {final3:F2}lv more.");
}
