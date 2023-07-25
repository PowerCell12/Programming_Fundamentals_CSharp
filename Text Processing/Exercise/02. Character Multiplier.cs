using System;


class Program {
  public static void Main (string[] args) {   

    
    List<string> strings = Console.ReadLine().Split().ToList();


    string string1 = strings[0];
    string string2 = strings[1];
    double final = 0;
    int length  = 0;


    if (string1.Length  > string2.Length){

      length = string2.Length;
    }
    else if (string1.Length < string2.Length){

      length = string1.Length;
    }
    else{
      length = string1.Length;
    }



    for (int i = 0; i < length; i++){

      final += (int)string1[i] * (int)string2[i];
    }




    if (string1.Length  > length){

      for (int i = length; i < string1.Length; i++){

        final += (int)string1[i];

      }
    }
    else if (string2.Length > length){

      for (int i = length; i < string2.Length; i++){

        final += (int)string2[i];

      }
    }


    Console.WriteLine(final);


  }
}
