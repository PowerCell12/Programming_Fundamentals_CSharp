using System;
using System.Text.RegularExpressions;

class Program {
  public static void Main (string[] args) {   
 

    int wanted = int.Parse(Console.ReadLine());

    List<int> list = new List<int>();


    for (int i = 1; i <= wanted; i++) {

      if (i == 1){
        list.Add(1);
      }
      else if (i == 2){
        list.Add(1);
      }
      else{

        int to_add = list[list.Count - 1] + list[list.Count - 2];
        list.Add(to_add);

      }
    }

    Console.WriteLine(list[list.Count - 1]);




  }
}
