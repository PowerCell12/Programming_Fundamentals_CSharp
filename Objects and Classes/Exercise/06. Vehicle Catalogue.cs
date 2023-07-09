using System;
using System.Collections.Generic;
using System.Linq;

class Program {
  public static void Main (string[] args) {

    List<Vehicles> all  = new List<Vehicles>();
    
    while (true){

      string[] inputs = Console.ReadLine().Split().ToArray();

      if (inputs[0] == "End"){
        break;
      }
      
      Vehicles vehicle = new Vehicles(inputs[0], inputs[1], inputs[2], int.Parse(inputs[3]));

      all.Add(vehicle);
    }


    while (true){

      string name = Console.ReadLine();

      if (name == "Close the Catalogue"){
        break;
      }
      
      foreach(Vehicles vehicles1 in all){

        if (vehicles1.model == name){
          if (vehicles1.type == "car"){
            Console.WriteLine($"Type: Car");
          }
          else{
            Console.WriteLine($"Type: Truck");
          }
          Console.WriteLine($"Model: {vehicles1.model}");
          Console.WriteLine($"Color: {vehicles1.color}");
          Console.WriteLine($"Horsepower: {vehicles1.HorsePower}");
        }
      }
    }

    double sum1 = 0;
    double sum2 = 0;
    int count1 = 0; // cars
    int count2 = 0; // trucks


    foreach (Vehicles vehicle in all){
      if (vehicle.type == "car"){
        sum1 += vehicle.HorsePower;
        count1++;
      }
      else{
        sum2 += vehicle.HorsePower;
        count2++;
      }
    }

    double final1 = sum1 / count1;
    double final2 = sum2 / count2;

    Console.WriteLine($"Cars have average horsepower of: {final1:F2}.");
    Console.WriteLine($"Trucks have average horsepower of: {final2:F2}.");
  }
}


public class Vehicles{

  public string type { set; get; }
  public string model { set; get; }
  public string color { set; get; }
  public int HorsePower { set; get; }

  public Vehicles(string Type, string Model, string Color, int horse_power){
    type = Type;
    model = Model;
    color = Color;
    HorsePower = horse_power;
  }
  
}
