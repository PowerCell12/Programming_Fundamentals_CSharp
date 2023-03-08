string name = Console.ReadLine();
int age = int.Parse(Console.ReadLine());
double AveragGrade = double.Parse(Console.ReadLine());

Console.WriteLine($"Name: {name}, Age: {age}, Grade: {AveragGrade:F2}");
