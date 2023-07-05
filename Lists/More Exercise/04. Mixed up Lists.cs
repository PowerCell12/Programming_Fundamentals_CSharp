using System;
using System.Text.RegularExpressions;

class Program {
  public static void Main (string[] args) {   

    List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
    List<int> list2 = Console.ReadLine().Split().Select(int.Parse).ToList();

    int length = 0;

    if (list1.Count < list2.Count){
      length = list1.Count;
    }
    else if (list2.Count < list1.Count){
      length = list2.Count;
    }
    else{
      length = list2.Count;
    }

    List<int> to_get_from = new List<int>();


    for (int i = 0; i < length; i++){

      
      int num1=  list1[0];
      int num2=  list2[list2.Count - 1];

      list1.RemoveAt(0);
      list2.RemoveAt(list2.Count - 1);

      to_get_from.Add(num1);
      to_get_from.Add(num2);
    }

    List<int> FinalList = new List<int>();

    if (list1.Count == 0){

      FinalList  = list2;

    }
    else{
      FinalList = list1;
    }


    int from = 0;
    int to = 0;


    if (FinalList[0]  > FinalList[1]){
      from = FinalList[1];
      to = FinalList[0];
    }
    else{
      from = FinalList[0];
      to = FinalList[1];
    }

    List<int> toprint = new List<int>();

    for (int i = from + 1; i < to; i++){

      if (to_get_from.Contains(i)){
        for (int j  = 1; j <= to_get_from.Count(n => n == i); j++){
          toprint.Add(i);
        }
      }


    }


    foreach (int i in toprint){
      Console.Write($"{i} ");
    }






  }
}
