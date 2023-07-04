using System;
partial class Program {  
  public static void Main (string[] args)
    {

    List<double> numbers = Console.ReadLine().Split().Select(double.Parse).ToList();

    double[] explosion = Console.ReadLine().Split().Select(double.Parse).ToArray();
    int k_1 = 0;

    for (int i = 0; i < numbers.Count; i++){


      if (numbers[i] == explosion[0]){

        double to_remove_to = i  - explosion[1];

        if (to_remove_to < 0){
          to_remove_to = 0;
        }

        int to_remove_to1 = Convert.ToInt32(to_remove_to);
        int counter1 = 0;

        for (int j = to_remove_to1; j < numbers.Count; j++){

          if (counter1 == explosion[1]){
            break;
          }

          numbers.Remove(numbers[j]);
          k_1 = j;
          j -=  1;
          counter1++;
        }

        int counter = 0;

        for (int k = k_1; k  < numbers.Count; k++){

          if (counter == explosion[1] + 1){
            break;
          }

          numbers.Remove(numbers[k]);
          k--;
          counter++;

        }



      }
      
    }
    Console.WriteLine(numbers.Sum());
      }   
  }
