int how_many = int.Parse(Console.ReadLine());
int odd_number = 1;
int counter = 0;
int final = 0;

for (int i = 0; i <= 100; i++)
{
    if (counter == how_many)
    {   
        Console.WriteLine($"Sum: {final}");
        break;
    }

    final += odd_number;

    Console.WriteLine(odd_number);

    counter++;

    odd_number = odd_number + 2;
}
