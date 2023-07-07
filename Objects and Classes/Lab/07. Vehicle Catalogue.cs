using System;
partial class Program {
  public static void Main (string[] args) {

    List<Car> car = new List<Car>();
    List<Truck> truck = new List<Truck>();
    

    while (true) {

      List<string>  all  = Console.ReadLine().Split("/").ToList();

      if (all[0] == "end"){
        break;
      }

      if (all[0] == "Car") {
        Car car1 = new Car(all[1], all[2], int.Parse(all[3]));
        car.Add(car1);
      }
      else{
        Truck truck1 = new Truck(all[1], all[2], int.Parse(all[3]));
        truck.Add(truck1);
      }



    }

    List<Car> car_final =  car.OrderBy(c => c.Brand).ToList();
    List<Truck> truck_final = truck.OrderBy(c => c.Brand).ToList();

    if (car_final.Count > 0){
      Console.WriteLine("Cars:");
    }
    foreach(Car car2 in car_final) {
      Console.WriteLine($"{car2.Brand}: {car2.Model} - {car2.Horse_Power}hp");
    }

    if (truck_final.Count > 0){
      Console.WriteLine("Trucks:");
    }
    foreach(Truck truck2 in truck_final) {
      Console.WriteLine($"{truck2.Brand}: {truck2.Model} - {truck2.Weight}kg");
    }

  }
}




public class Truck{

  public string Brand { set; get;}
  public string Model { set; get; }
  public int Weight { set; get; }


  public Truck(string brand, string model, int weight) {

    Brand = brand;
    Model = model;
    Weight = weight;

  }


}


public class Car{

  public string Brand { set; get;}
  public string Model { set; get; }
  public int Horse_Power { set; get; }


  public Car(string brand, string model, int horse_power) {

    Brand = brand;
    Model = model;
    Horse_Power = horse_power;

  }
}



public class Catalog{

  public List<Truck> Trucks { set; get; }
  public List<Car> Cars { set; get; }


  public Catalog(List<Truck> trucks, List<Car> car){

    Trucks = trucks;
    Cars = car;
  }



}
