using System;
using System.Text.RegularExpressions;

class Program {
  public static void Main (string[] args) {   


    List<int> cards1 = Console.ReadLine().Split().Select(int.Parse).ToList();
    List<int> cards2 = Console.ReadLine().Split().Select(int.Parse).ToList();


    while (true){

      if (cards1.Count == 0){
        Console.WriteLine($"Second player wins! Sum: {cards2.Sum()}");
        break;
      }
      else if (cards2.Count == 0){
        Console.WriteLine($"First player wins! Sum: {cards1.Sum()}");
        break;
      }


      int first = cards1[0];
      int second = cards2[0];

      cards1.RemoveAt(0);
      cards2.RemoveAt(0);


      if (first > second){
        cards1.Add(first);
        cards1.Add(second);
      }
      else if (second > first){
        cards2.Add(second);
        cards2.Add(first);
      }

    }


  }
}
