using System;


class Program {
  public static void Main (string[] args) {   


    int lines = int.Parse(Console.ReadLine());
    Family family = new Family();

    for (int i = 0; i < lines; i++){

      List<string> data = Console.ReadLine().Split(' ').ToList();

      Person person = new Person(data[0], int.Parse(data[1]));

      family.AddMember(person);

    }


    List<Person> people = family.People.OrderByDescending(x => x.Age).ToList();

    foreach(Person person in people){
      Console.WriteLine($"{person.Name} {person.Age}");
      break;
    }


  }
}



public class Person{

  public string Name {get; set; }
  public int Age {get; set; }

  public Person(string name, int age){
    this.Name = name;
    this.Age = age;
  }
}


public class Family{

  public List<Person> People {get; set;}

  public Family(){
    this.People = new List<Person>();
  }

  public void AddMember(Person person){

    this.People.Add(person);

  }




}
