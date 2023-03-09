int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

minutes = minutes + 30;

if (minutes >= 60)
{
    hours++;
    minutes = minutes - 60;
}

if (hours == 24)
{
    hours = 0;
}

if (minutes > 9)
{
    Console.WriteLine($"{hours}:{minutes}");
}
else
{
    Console.WriteLine($"{hours}:0{minutes}");
}
