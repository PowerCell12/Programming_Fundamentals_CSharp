bool if_yeah = true;

while (if_yeah)
{
  int numbers = int.Parse(Console.ReadLine());

  if (numbers % 2 == 0)
  {
    numbers = Math.Abs(numbers);
    Console.WriteLine($"The number is: {numbers}");
    if_yeah = false;
  }

  if (numbers % 2 != 0)
  {
    Console.WriteLine("Please write an even number.");
  }
}
