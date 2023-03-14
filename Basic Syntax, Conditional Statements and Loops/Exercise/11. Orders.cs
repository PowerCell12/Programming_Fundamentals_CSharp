int orders = int.Parse(Console.ReadLine());
double total = 0;

for (int i = 1; i <= orders; i++)
{
  double priceCapsule = double.Parse(Console.ReadLine());
  int days = int.Parse(Console.ReadLine());
  int countCapsules = int.Parse(Console.ReadLine());

  double priceCoffee = (days * countCapsules) * priceCapsule;

  Console.WriteLine($"The price for the coffee is: ${priceCoffee:F2}");

  total += priceCoffee;
}

Console.WriteLine($"Total: ${total:F2}");
