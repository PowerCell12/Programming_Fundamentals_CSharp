using System;


class Program {
  public static void Main (string[] args) {   


    List<string> peoples = Console.ReadLine().Split(';').ToList();
    List<string> foods = Console.ReadLine().Split(';').ToList();

    List<Person> all_people = new List<Person>();
    List<Product> all_products = new List<Product>();


    foreach(var person in peoples){


      List<string> final  = person.Split("=").ToList();

      Person person1 = new Person(final[0], double.Parse(final[1]));
      all_people.Add(person1);
    }

    foreach (var product in foods){

      List<string> final = product.Split("=").ToList();

      if (final[0] != ""){

        Product product1 = new Product(final[0], double.Parse(final[1]));
        all_products.Add(product1);
      }
    }


    while (true){

      List<string> command = Console.ReadLine().Split(" ").ToList();

      if (command[0] == "END"){
        break;
      }

      foreach(var person in all_people){

        if(person.Name == command[0]){

          foreach(var product in all_products){

            if (product.Name == command[1]){

              person.buyproduct(product);
             }
        }
          }
      }
    }


    foreach(var person in all_people){
      
      if (person.Bag.Count == 0){
        Console.WriteLine($"{person.Name} - Nothing bought");
      }
      else{
          Console.WriteLine($"{person.Name} - {string.Join(", ", person.Bag.Select(item => item.Name))}");
      }
    }



  }
}



public class Person{

  public string Name {get; set; }
  public double Money {get; set; }

  public List<Product> Bag {get; set;}

  public Person(string name, double money){

    this.Name = name;
    this.Money = money;
    this.Bag = new List<Product>();
  }

  public void buyproduct(Product product){

    if (this.Money >= product.Cost){
      this.Bag.Add(product);
      this.Money -= product.Cost;
      Console.WriteLine($"{this.Name} bought {product.Name}");
    }
    else{
      Console.WriteLine($"{this.Name} can't afford {product.Name}");
    }

  }

}


public class Product{

  public string Name{get; set;}

  public double Cost{get; set;}

  public Product(string name, double cost){
    this.Name = name;
    this.Cost = cost;
  }

}
