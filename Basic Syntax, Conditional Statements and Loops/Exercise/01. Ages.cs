int age = int.Parse(Console.ReadLine());


if (age >= 0 && age <= 2)
{
  Console.WriteLine("baby");
}

if (age > 2 && age < 14)
{
  Console.WriteLine("child");
}

if (age > 13 && age < 20)
{
    Console.WriteLine("teenager");
}

if (age > 19 && age < 66)
{
    Console.WriteLine("adult");
}

if (age > 65)
{
    Console.WriteLine("elder");
}
