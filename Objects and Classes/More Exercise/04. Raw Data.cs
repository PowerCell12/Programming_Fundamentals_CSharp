using System;


class Program {
  public static void Main (string[] args) {   


    int lines = int.Parse(Console.ReadLine());
    List<Car> cars = new List<Car>();

    for (int i = 0; i < lines; i++){

      List<string> data = Console.ReadLine().Split().ToList();

      Car car = new Car(data[0], int.Parse(data[1]), int.Parse(data[2]), int.Parse(data[3]), data[4]);

      cars.Add(car);

    }


    string type1 = Console.ReadLine();

    if (type1 == "fragile"){
        
      foreach(var car in cars){

        if (car.cargo.Type == "fragile" && car.cargo.Weight < 1000){
          Console.WriteLine(car.Model);
        }
      }

    }
    else if (type1 == "flamable"){
      
      foreach(var car in cars){

        if (car.cargo.Type == "flamable" && car.engine.Power > 250){
          Console.WriteLine(car.Model);
        }

      }
  }
}


public class Car{

  public string Model {get; set; }

  public Engine engine {get; set; }

  public Cargo cargo {get; set; }

  public Car(string model, int speed, int power, int weight, string type){
    this.Model = model;
    this.engine = new Engine(speed, power);
    this.cargo = new Cargo(weight, type);
  }

}


public class Engine{

  public int Speed {get; set; }
  public int Power {get; set; }

  public Engine(int speed, int power){
    this.Speed = speed;
    this.Power = power;
  }

}

public class Cargo{

  public int Weight{get; set; }
  public string Type {get; set; }

  public Cargo(int weight, string type){
    this.Weight = weight;
    this.Type = type;
  }


}
}
