int first = int.Parse(Console.ReadLine());
    int second = int.Parse(Console.ReadLine());

    if (second > 10)
    {
      int final = second * first;
      Console.WriteLine($"{first} X {second} = {final}");
    }

    for (int i = first; i <= first; i++)
    {
    for (int j = second; j <= 10; j++)
    {
      if (second > 10)
      {
        break;
      }
      int final1 = i * j;
      Console.WriteLine($"{i} X {j} = {final1}");
    }
    if (second > 10)
    {
      break;
    }
}
