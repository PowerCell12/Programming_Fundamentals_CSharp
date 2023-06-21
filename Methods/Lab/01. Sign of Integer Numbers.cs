static void Sign(int number)
{
    if (number < 0){
        Console.WriteLine($"The number {number} is negative. ");
    }
    else if (number > 0){
        Console.WriteLine($"The number {number} is positive. ");
    }
    else{
        Console.WriteLine($"The number {number} is zero.");
    }
}

Sign(int.Parse(Console.ReadLine()));
