using System;


class Program {
  public static void Main (string[] args) {   


    int lines = int.Parse(Console.ReadLine());
    List<Car> all_cars = new List<Car>();

    for(int i  = 0; i < lines; i++){

      List<string> car =  Console.ReadLine().Split(' ').ToList();

      Car car1 = new Car(car[0], double.Parse(car[1]), double.Parse(car[2]));
      all_cars.Add(car1);

    }

    while (true){

      List<string> command = Console.ReadLine().Split(' ').ToList();

      if (command[0] == "End"){
        break;
      }

      foreach(Car car in all_cars){

        if (car.Model == command[1]){

          car.Drive(int.Parse(command[2]));
        }
      }
    }


    foreach(Car car in all_cars){

      Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TraveledDistance}");

    }



  }
}



public class Car{


  public string Model { get; set;}
  public double FuelAmount { get; set; }

  public double FuelConsumption {get; set; }

  public double TraveledDistance {get; set;}

  public Car(string model, double fuelAmount, double fuelConsumption){

    this.Model = model;
    this.FuelAmount = fuelAmount;
    this.FuelConsumption = fuelConsumption;
    this.TraveledDistance  = 0;
  }

  public  void Drive(int distance){

      double fuelNeeded = distance * this.FuelConsumption;

      if (fuelNeeded > this.FuelAmount){

        Console.WriteLine($"Insufficient fuel for the drive");
      }
      else{
        this.FuelAmount -= fuelNeeded;
        this.TraveledDistance += distance;
      }
    }
  }
