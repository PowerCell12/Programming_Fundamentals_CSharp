int number = int.Parse(Console.ReadLine());
    int counter = 1;
    int counter1 = 0;
    
    for (int i = 1; i <= number; i++)
    {
      counter1 += 1;
      for (int j = 1; j <= counter; j++)
      {
        Console.Write(counter1);
        Console.Write(" ");
      }

      Console.WriteLine(" ");
      counter += 1;
    }
