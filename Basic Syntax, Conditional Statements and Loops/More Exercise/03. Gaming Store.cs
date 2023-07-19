using System;

class Program {
  public static void Main (string[] args) {
    double money = double.Parse(Console.ReadLine());
double money_needed = 0;
double spend = 0;

while (true)
{
  string game = Console.ReadLine();

  if (game == "OutFall 4")
  {
    money_needed = 39.99;
  }  
  else if (game == "CS: OG")
  {
    money_needed = 15.99;
  }
  else if (game == "Zplinter Zell")
  {
    money_needed = 19.99;
  }
  else if (game == "Honored 2")
  {
    money_needed = 59.99;
  }
  else if (game == "RoverWatch")
  {
    money_needed = 29.99;
  }
  else if (game == "RoverWatch Origins Edition")
  {
    money_needed = 39.99;
  }
  else if (game == "Game Time")
  {
    Console.WriteLine($"Total spent: ${spend:F2}. Remaining: ${money:F2}");
    break;
  }
  else
  {
    Console.WriteLine("Not Found");
    continue;
  }


  if (money - money_needed >= 0)
  {
    Console.WriteLine($"Bought {game}");
    spend += money_needed;
    money = money - money_needed;
  }
  else
  {
    Console.WriteLine("Too Expensive");
    continue;
  }

  if (money == 0)
  {
    Console.WriteLine("Out of money!");
    break;
  }
}
  }
}
