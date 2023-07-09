using System;


class Program {
  public static void Main (string[] args) {   


    int lines = int.Parse(Console.ReadLine());
    List<Employee> final = new List<Employee>();


    for (int i = 0; i < lines; i++){

      List<string> employees1 = Console.ReadLine().Split().ToList();

      Employee employee  = new Employee(employees1[0], double.Parse(employees1[1]), employees1[2]);

      final.Add(employee);

    }

    Dictionary<string, List<double>> dict = new Dictionary<string, List<double>>();
    Dictionary<string, double> dict2 = new Dictionary<string, double>();


    foreach(Employee employee in final){

      if (!dict.ContainsKey(employee.Department)){

        dict[employee.Department] = new List<double>();
      
      }

      dict[employee.Department].Add(employee.Salary);
      dict2[employee.Name] = employee.Salary;


    }

    dict = dict.OrderByDescending(x => x.Value.Sum()).ToDictionary(x => x.Key, x => x.Value);


    foreach(KeyValuePair<string, List<double>> kvp in dict){

      Console.WriteLine($"Highest Average Salary: {kvp.Key}");


      List<double> second  = kvp.Value.OrderByDescending(x => x).ToList();
      foreach(double salary in second){

        foreach(KeyValuePair<string, double> kvp2 in dict2){


          if (salary == kvp2.Value){

            
            Console.WriteLine($"{kvp2.Key} {kvp2.Value:F2}");
            break;
          }
        }


      }


      break;
    }




  }
}



public class Employee{

  public string Name {get; set; }
  public double Salary {get; set; }
  public string Department {get; set; }


  public Employee(string name, double  salary, string department ){
    this.Name = name;
    this.Salary = salary;
    this.Department = department;
  }



}
