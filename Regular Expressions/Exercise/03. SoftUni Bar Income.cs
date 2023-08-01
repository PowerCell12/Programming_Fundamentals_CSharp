using System;
using System.Text.RegularExpressions;

class Program {
  public static void Main (string[] args) {
    double totalprice= 0;

    while (true){

      string line = Console.ReadLine();

      if (line == "end of shift"){
        break;
      }

      string pattern = @"%(?<name>[A-Z][a-z]+)%[a-zA-Z0-9_]*<(?<product>\w+)>[a-zA-Z0-9_]*\|(?<quantity>[0-9]+)\|[a-zA-Z_]*(?<price>[0-9]+|[0-9]+\.[0-9]+)\$";
      Regex regex = new Regex(pattern);

      Match final = regex.Match(line);

      if (final.Groups["price"].Value != "" | final.Groups["quantity"].Value != "" | final.Groups["name"].Value != "" | final.Groups["product"].Value != ""){
        double price = Convert.ToInt32(final.Groups["quantity"].Value) * Convert.ToDouble(final.Groups["price"].Value);
        Console.WriteLine($"{final.Groups["name"].Value}: {final.Groups["product"].Value} - {price:F2}");

        totalprice +=  price;
      }
    }

    Console.WriteLine($"Total income: {totalprice:F2}");
    
  }
}
