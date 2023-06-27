using System;

class Program {
  public static void Main (string[] args) {

  
    static void Coffee(int quantity){
      var final = quantity * 1.50;
      Console.WriteLine(($"{final:F2}"));
    }


    static void Water(int quantity){
      var final = quantity * 1.00;
      Console.WriteLine($"{final:F2}");
    }

    static void coke(int quantity){
      var final = quantity * 1.40;
      Console.WriteLine($"{final:F2}");
    }

    static void snacks(int quantity){
      var final = quantity * 2.00;
      Console.WriteLine($"{final:F2}");
    }


    string product = Console.ReadLine();
    int quantity = int.Parse(Console.ReadLine());

    if (product == "coffee"){
      Coffee(quantity);
    }
    else if ( product == "water"){
      Water(quantity);
    }
    else if (product == "coke"){
      coke(quantity);
    }
    else{
      snacks(quantity);
    }
    
    
  }
}
