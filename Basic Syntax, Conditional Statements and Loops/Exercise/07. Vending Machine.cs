double all_money = 0;
    double coins1 = 0;
    
while (true)
{
  string coins = Console.ReadLine();

  if (coins == "Start")
      break;

  coins1 = double.Parse(coins);

  if (coins1 != 2 && coins1 != 1 && coins1 != 0.5 && coins1 != 0.2 && coins1 != 0.1)
  {
    Console.WriteLine($"Cannot accept {coins1}");
    continue;
  }

  all_money += coins1;
}

double money_needed =  0;
    
while (true)
{
    string product = Console.ReadLine();

    if (product == "End")
    {
      Console.WriteLine($"Change: {all_money:F2}");
       break;
    }

    if (product == "Nuts")
    {
      money_needed = 2.0;
    }
    else if (product == "Water")
    {
      money_needed = 0.7;
    }
    else if (product == "Crisps")
    {
      money_needed = 1.5;
    }
    else if (product == "Soda")
    {
      money_needed = 0.8;
    }
    else if (product == "Coke")
    {
      money_needed = 1.0;
    }
    else
    {
      Console.WriteLine("Invalid product");
      continue;
    }
    
    if (all_money - money_needed >= 0)
    {
      string lower = product.ToLower();
      Console.WriteLine($"Purchased {lower}");
      all_money = all_money - money_needed;
    }
    else
    {
      Console.WriteLine("Sorry, not enough money");
      continue;
    }
}
