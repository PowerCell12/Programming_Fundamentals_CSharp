static void Add(int number1, int number2){

    Console.WriteLine($"{number1 + number2}");
}

static void Subtract(int number1, int number2)
{
    Console.WriteLine($"{number1 - number2}");
}

static void Multiply(int number1, int number2)
{
    Console.WriteLine($"{number1 * number2}");
}

static void Divide(int number1, int number2)
{
    Console.WriteLine($"{number1 / number2}");
}

string Type = Console.ReadLine();
int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());

if (Type == "add"){
    Add(number1, number2);
}
else if (Type == "subtract"){
    Subtract(number1, number2);
}
else if (Type == "multiply"){
    Multiply(number1, number2);
}
else if (Type == "divide"){
    Divide(number1, number2);
}
