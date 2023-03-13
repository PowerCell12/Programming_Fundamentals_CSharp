int countPeople = int.Parse(Console.ReadLine());
string type = Console.ReadLine();
string day =  Console.ReadLine();
double money = 0;


if (type == "Students")
{
  if (day == "Friday")
  {
    money = 8.45;
  }
  else if (day == "Saturday")
  {
    money = 9.80;
  }
  else if (day == "Sunday")
  {
    money = 10.46;
  }
}

if (type == "Business")
{
  if (day == "Friday")
  {
    money = 10.90;
  }
  else if (day == "Saturday")
  {
    money = 15.60;
  }
  else if (day == "Sunday")
  {
    money = 16;
  }
}


if (type == "Regular")
{
  if (day == "Friday")
  {
    money = 15;
  }
  else if (day == "Saturday")
  {
    money = 20;
  }
  else if (day == "Sunday")
  {
    money = 22.50;
  }
}

if (countPeople >= 100 && type == "Business")
{
  countPeople = countPeople - 10;
}

double total = money  * countPeople;

if (countPeople >= 30 && type == "Students")
{
  total = total - total * 0.15;
}

if (countPeople > 9 && countPeople < 21 && type == "Regular")
{
  total = total - total * 0.05;
}

Console.WriteLine($"Total price: {total:F2}");
