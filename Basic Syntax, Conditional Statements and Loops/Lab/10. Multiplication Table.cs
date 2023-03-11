int integer = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    int final = integer * i;

    Console.WriteLine($"{integer} X {i} = {final}");
}
