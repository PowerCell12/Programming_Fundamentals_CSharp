using System;


class Program {
  public static void Main (string[] args) {   


    List<string> NumAndLet = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
    double totalsum = 0;

    foreach(var item in NumAndLet)
    {
      char first=  item[0];
      char last = item[item.Length-1];
      double num   = Convert.ToInt32(item.Substring(1, item.Length - 2));


      if (char.IsUpper(first)){
        num /= (int)first - 64;
      }
      else{
        num *=  (int)first - 96;
      }

      if(char.IsUpper(last)){
        num -= (int)last - 64;
      }
      else{
        num += (int)last - 96;
      }

      totalsum += num;

    }


    Console.WriteLine($"{totalsum:F2}");




  }
}
