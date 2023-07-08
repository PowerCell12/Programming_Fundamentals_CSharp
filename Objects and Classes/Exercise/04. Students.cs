using System;
using System.Collections.Generic;
using System.Linq;

class Program {
  public static void Main (string[] args) {

    int all =  int.Parse(Console.ReadLine());
    List<Student> all_final = new List<Student>();
    
    for(int i = 0; i < all; i++){
  
      List<string> info = Console.ReadLine().Split().ToList();


      Student student  = new Student(info[0], info[1], double.Parse(info[2]));
      all_final.Add(student);
    }

    List<Student> Sorted = all_final.OrderByDescending(x => x.Grade).ToList();

// left -- just print 
  foreach(Student student_final in Sorted){
    Console.WriteLine($"{student_final.First_Name} {student_final.Last_Name}: {student_final.Grade:F2}");
  }
    
  }
}


public class Student{

  public string First_Name { set; get; }
  public string Last_Name { set; get; }
  public double Grade { set; get; }

  public Student(string first_name, string last_name, double grade){
    First_Name = first_name;
    Last_Name = last_name;
    Grade = grade;
  }

  
}
