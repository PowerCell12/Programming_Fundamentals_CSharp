using System;
partial class Program {  
  public static void Main (string[] args) {    

    string strings  = Console.ReadLine();
    string vowels = "aeiouAEIOU";

    int count = vowels1(strings, vowels);
    Console.WriteLine(count);



    static int vowels1(string strings, string vowels){
        int count = 0;

        foreach (char s in strings) {   
            if (vowels.Contains(s)){
                count++;
            }
        }   

        return count;

    }

  }

  }
