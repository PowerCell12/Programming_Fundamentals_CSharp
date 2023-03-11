string type = Console.ReadLine();
int age = int.Parse(Console.ReadLine());
int money = 0;

switch (type)
{
    case "Weekday":
    if (age < 0 || age > 122)
    { 
     Console.WriteLine("Error!");   
    }
    if (0 <= age && age <= 18)
    {
        money = 12;
    }
    else if (18 < age && age <= 64)
    {
        money = 18;
    }
    else if (64 < age && age <= 122)
    {
        money = 12;
    }
    break;
        
    case "Weekend":
    if (age < 0 || age > 122)
    { 
     Console.WriteLine("Error!");   
    }
    if (0 <= age && age <= 18)
    {
        money = 15;
    }
    else if (18 < age && age <= 64)
    {
        money = 20;
    }
    else if (64 < age && age <= 122)
    {
        money = 15;
    }
    break;
    case "Holiday":
    if (age < 0 || age > 122)
    { 
     Console.WriteLine("Error!");   
    }
    if (0 <= age && age <= 18)
    {
        money = 5;
    }
    else if (18 < age && age <= 64)
    {
        money = 12;
    }
    else if (64 < age && age <= 122)
    {
        money = 10;
    }
    break;
}

if (money != 0)
{
    Console.WriteLine($"{money}$");
}
