using System;
using System.Text.RegularExpressions;

class Program {
  public static void Main (string[] args) {   
    

    int how_names = int.Parse(Console.ReadLine());
    string vowels = "aeiouAEIOU";
    List<double> data = new List<double>();


    for (int i = 0; i < how_names; i++) {

      string name = Console.ReadLine();
      double final = 0;

      foreach (char c in name){


        bool isVowel = "aeiouAEIOU".IndexOf(c) >= 0;

        if (char.IsLetter(c)){

            if (isVowel){
                final += (int)c * name.Length;
            }
            else{
              final += (int)c / name.Length;
            }


        }
      }

      data.Add(final);

    }


    data.Sort();

    foreach( double data1 in data){
      Console.WriteLine(data1);
    }





  }
}
