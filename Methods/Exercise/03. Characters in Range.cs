using System;

partial class Program {  
  public static void Main (string[] args) {    

    char chractacter1 = char.Parse(Console.ReadLine());
    char chractacter2 = char.Parse(Console.ReadLine());

    char beginning = chractacter1;
    char ending = chractacter2;

    if ((int)chractacter1 < (int)chractacter2){
      beginning = chractacter1;
      ending = chractacter2;
    }
    else{
      beginning = chractacter2;
      ending = chractacter1;
    }

 
  for (int i = (int)beginning + 1; i < (int)ending; i++){
    Console.Write((char)i + " ");
  }
 
  }
}
