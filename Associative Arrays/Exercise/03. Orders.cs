using System;
using System.Collections.Generic;
using System.Linq;

class Program {
  public static void Main (string[] args) {

    Dictionary<string, Dictionary<double, double>> product = new Dictionary<string, Dictionary<double, double>>();


    while (true) {

      List<string> product_f  = Console.ReadLine().Split().ToList();

      if (product_f[0] == "buy"){
        break;
      }

      if (product.ContainsKey(product_f[0])){

        if (!product[product_f[0]].ContainsKey(double.Parse(product_f[1]))){

          double needed = 0;

          foreach(KeyValuePair<double, double> pair in product[product_f[0]]){
            needed += pair.Value;
            break;
          }

          product.Remove(product_f[0]);
          product[product_f[0]] = new Dictionary<double, double>();
          product[product_f[0]].Add(double.Parse(product_f[1]), needed + double.Parse(product_f[2]));

        }
        else{
          product[product_f[0]][double.Parse(product_f[1])] += double.Parse(product_f[2]);
        }


      }
      else{
        product[product_f[0]] = new Dictionary<double, double>();
        product[product_f[0]].Add(double.Parse(product_f[1]), double.Parse(product_f[2]));
      }

    }

    foreach(KeyValuePair<string, Dictionary<double, double>> pair in product){

      double final_value = 0;

      foreach(KeyValuePair<double, double> pair_value in pair.Value){

        final_value += pair_value.Key * pair_value.Value;

      }

      Console.WriteLine($"{pair.Key} -> {final_value:F2}");

    }



  }
}
