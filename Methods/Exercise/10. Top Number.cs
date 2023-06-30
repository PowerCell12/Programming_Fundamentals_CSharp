using System;
partial class Program {  
  public static void Main (string[] args) {    


    int numbers = int.Parse(Console.ReadLine());

    TopNumbers(numbers);
  }


  static void TopNumbers(int numbers){

    for (int i = 1; i <= numbers; i++) {
      int sum = 0;
      int count_odd = 0;

      
      foreach (char j in Convert.ToString(i)) {

        sum += Convert.ToInt32(j);
        if (Convert.ToInt32(j) % 2 != 0) {
          count_odd += 1;
        }
      }

      if (count_odd > 0 && sum % 8 == 0){
        Console.WriteLine(i);
      }

      }



    }


  }
