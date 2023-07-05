using System;
using System.Text.RegularExpressions;

class Program {
  public static void Main (string[] args) {   

    
    double money = double.Parse(Console.ReadLine());

    List<int> quality  = Console.ReadLine().Split().Select(int.Parse).ToList();

    List<int> initiall_quality = new List<int>(quality);



    while (true){

      string hit_power = Console.ReadLine();

      if (hit_power == "Hit it again, Gabsy!"){
        break;
      }


      int hit_power1 = int.Parse(hit_power);


      for (int i = 0; i < quality.Count; i++){

        quality[i] -= hit_power1;

        if (quality[i] <= 0){

          if (money - initiall_quality[i] * 3 >= 0){

            quality[i] = initiall_quality[i];
            money -= initiall_quality[i] * 3;

          }
          else{
            quality.RemoveAt(i);
            initiall_quality.RemoveAt(i);
            i--;
            

          }
        }


      }

    }


    Console.WriteLine(string.Join(" ", quality));
    Console.WriteLine($"Gabsy has {money:F2}lv.");


  }
}
