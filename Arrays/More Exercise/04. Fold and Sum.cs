using System;
using System.Text.RegularExpressions;

class Program {
  public static void Main (string[] args) {   
 

    List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();


    int middle = list.Count / 2;

    int left = middle / 2;

    List<int> left1  = new List<int>();
    List<int> right = new List<int>();
    List<int> middle1 = new List<int>();



    for (int i = 0; i < list.Count; i++){

      if (i +  1 <= left){
        left1.Add(list[i]);
      }
      else if (i + 1 > left && i + 1 <= middle + left){
        middle1.Add(list[i]);
      }
      else{
        right.Add(list[i]);
      }


    }

    left1.Reverse();
    right.Reverse();

    List<int> result  = left1.Concat(right).ToList();
    List<int> final = new List<int>();

    for (int i = 0; i   < result.Count; i++){

      final.Add(result[i]  + middle1[i]);
    }


    Console.WriteLine(string.Join(" ", final));




  }
}
