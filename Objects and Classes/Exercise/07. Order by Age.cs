using System;
using System.Collections.Generic;
using System.Linq;

class Program {
  public static void Main (string[] args) {

    List<Person> all = new List<Person>();
    bool bool1 = false;
   
    while (true) {

      List <string> list = Console.ReadLine().Split().ToList();


      if (list[0] == "End") {
          break;
      }

      Person person = new Person(list[0], list[1], int.Parse(list[2]));
    
      foreach (Person person1 in all) {

        if (person1.ID == person.ID) {
          person1.Name = person.Name;
          person1.Age = person.Age;
          bool1 = true;
        }

      }
    
      if (!bool1) {
        all.Add(person);
      }
      bool1 = false;
    }


    List<Person> final = all.OrderBy(p => p.Age).ToList();

    foreach (Person final1 in final) {

      Console.WriteLine($"{final1.Name} with ID: {final1.ID} is {final1.Age} years old.");

    }

  }
}



public class Person{

  public string Name { set; get; }
  public string ID { set; get; }
  public int Age { set; get; }


  public Person(string name, string id, int age){
    Name = name;
    ID = id;
    Age = age;
  }

}
