using System;
using System.Text.RegularExpressions;

class Program {
  public static void Main (string[] args) {   

    List<string> courses = Console.ReadLine().Split(", ").ToList();

    while (true){

      string commands  = Console.ReadLine();

      if (commands == "course start"){
        break;
      }

      List<string> commands1 = commands.Split(":").ToList();


      if (commands1[0] == "Add" && !courses.Contains(commands1[1])){
        courses.Add(commands1[1]);
      }
      else if (commands1[0] == "Insert" && !courses.Contains(commands1[1])){
        courses.Insert(int.Parse(commands1[2]), commands1[1]);
      }



      else if (commands1[0] == "Remove" && courses.Contains(commands1[1])){

        int idx = courses.IndexOf(commands1[1]);

        if (courses[idx + 1] == $"{commands1[1]}-Exercise"){
          courses.RemoveAt(idx + 1);
        }

        courses.Remove(commands1[1]);
      }

      else if (commands1[0] == "Swap" && courses.Contains(commands1[1]) && courses.Contains(commands1[2])){
        
        int idx1 = courses.IndexOf(commands1[1]);
        int idx2 = courses.IndexOf(commands1[2]);

        int idx1_plus1 = idx1 + 1;
        int idx2_plus1 = idx2 + 1;

        if (idx1_plus1 >= courses.Count){
          idx1_plus1 = idx1;
        }
        else if (idx2_plus1 >= courses.Count){
          idx2_plus1 = idx2;
        }


        // if there isnt any exerises
        if (courses[idx1_plus1] != $"{commands1[1]}-Exercise" && courses[idx2_plus1] != $"{commands1[2]}-Exercise")
        {
          string temp = commands1[1];

          courses[idx1] = courses[idx2];
          courses[idx2] = temp;
        }




        // if first has exercise
        if (courses[idx1_plus1] == $"{commands1[1]}-Exercise"){

          string temp = commands1[1];

          courses[idx1] = courses[idx2];
          courses[idx2] = temp;
          string final = $"{commands1[1]}-Exercise";

          courses.Remove($"{commands1[1]}-Exercise");
          courses.Insert(idx2 + 1, final);
        }

        // if second has exercise
        if (courses[idx2_plus1] == $"{commands1[2]}-Exercise"){

          string temp = commands1[1];

          courses[idx1] = courses[idx2];
          courses[idx2] = temp;
          string final = $"{commands1[2]}-Exercise";

          courses.Remove($"{commands1[2]}-Exercise");
          courses.Insert(idx1 + 1, final);
        }

      }


      else if (commands1[0] == "Exercise"){

        int idx = courses.IndexOf(commands1[1]);

        if (idx == -1){

          courses.Add(commands1[1]);
          courses.Add($"{commands1[1]}-Exercise");

        }
        else{
          if (courses[idx + 1] != $"{commands[1]}-Exercise"){
            courses.Insert(idx + 1, $"{commands[1]}-Exercise");
          }
        }
      }


    }

    int count = 0;
    foreach(string thing in courses){
      count++;
      Console.WriteLine($"{count}.{thing}");
    }


  }
}
