using System;

class Program {
  public static void Main (string[] args) {
    int poke_power = int.Parse(Console.ReadLine());
int distance = int.Parse(Console.ReadLine());
int old_one = poke_power;
int poked_ones = 0;
int exhaustion_fac = int.Parse(Console.ReadLine());

while (poke_power >= distance)
{

  poke_power = poke_power - distance;
  poked_ones = poked_ones + 1;

  if (poke_power * 2 == old_one && poke_power >= exhaustion_fac && exhaustion_fac != 0)
  {
    poke_power = poke_power / exhaustion_fac;
  }
}

Console.WriteLine(poke_power);
Console.WriteLine(poked_ones);
  }
}
