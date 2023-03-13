string username = Console.ReadLine();
    string reversed = string.Empty;

    for (int i = username.Length - 1; i >= 0; i--)
    {
      reversed += username[i];
    }

    string tried = string.Empty;
    int counter = 0;
    
    while (reversed != tried)
    {
      tried = Console.ReadLine();

      counter += 1;
      if (counter == 4)
      {
        Console.WriteLine($"User {username} blocked!");
        break;
      }
      
      if (tried != reversed)
      {
        Console.WriteLine("Incorrect password. Try again.");
      }
      else
      {
        Console.WriteLine($"User {username} logged in.");
        break;
      }
    }
