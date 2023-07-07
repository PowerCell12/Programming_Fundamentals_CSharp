using System;
partial class Program {
  public static void Main (string[] args) {

    List<Student> store = new List<Student>();


    while (true) {

      List<string> info  = Console.ReadLine().Split().ToList();


      if (info[0] == "end"){
        break;
      }

      Student student = new Student(info[0], info[1], info[2], info[3]);

      store.Add(student);
    }

    bool bool1 = false;
    string city = Console.ReadLine();
    List<Student> StoreFinal  = new List<Student>();
// logic here for removing duplicate

    
    for (int i = 0; i < store.Count; i++) {

      for (int j = 0; j < i; j ++) {

        if (store[j].FirstName == store[i].FirstName || store[j].LastName == store[i].LastName) {

          StoreFinal.Remove(store[j]);

        }

      }

      StoreFinal.Add(store[i]);
      
    
    
    }

    foreach(Student student1 in StoreFinal) {

      if (student1.HomeTown == city) {

        Console.WriteLine($"{student1.FirstName} {student1.LastName} is {student1.age} years old.");

      }

    }

  }
}



public class Student{

  public string FirstName { set; get; }
  public string LastName { set; get; }
  public string age { set; get; }
  public string HomeTown { set; get; }


  public Student(string FirstName1, string LastName1, string age1, string HomeTown1) {

    FirstName = FirstName1;
    LastName = LastName1;
    age = age1;
    HomeTown = HomeTown1;
  }


}
