using System;
partial class Program {  
  public static void Main (string[] args)
    {


      int lines = int.Parse(Console.ReadLine());
      List<string> products = new List<string>();


      for (int i = 0; i < lines; i++){

        products.Add(Console.ReadLine());
      }


      products.Sort();
      int counter = 1;

      foreach( string product in products ){

        Console.WriteLine($"{counter}.{product}");
        counter++;
      }



    }

}
