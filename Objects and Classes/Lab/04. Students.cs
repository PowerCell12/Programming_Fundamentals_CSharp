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


    string city = Console.ReadLine();

    foreach(Student student in store) {

      if (student.HomeTown == city) {

        Console.WriteLine($"{student.FirstName} {student.LastName} is {student.age} years old.");

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
