using System;


class Program {
  public static void Main (string[] args) {   

    int teams = int.Parse(Console.ReadLine());

    List<Team> team = new List<Team>();

    for (int i = 0; i  < teams; i++){

      List<string> command = Console.ReadLine().Split("-").ToList();

      team.Add(new Team(command[0], command[1]));


      Console.WriteLine($"Team {command[1]} has been created by {command[0]}!");
    }


    while (true){
      
      List<string> command = Console.ReadLine().Split("->").ToList();

      if (command[0] == "end of assignment"){
        break;
      }

      Team team1 = new Team(command[0], command[1]);

      bool bool1 = false;
      bool bool2 = false;
      bool bool3 = false;
      bool bool4 = false;


      foreach (Team team2 in team){

        if (team2.Creater == command[0] && team2.NameGroup == command[1]){
          Console.WriteLine($"Team {command[1]} was already created!");
          bool1 = true;
          break;
        }

        if (team2.Creater == command[0] && team2.NameGroup != command[1]){
          Console.WriteLine($"{command[0]} cannot create another team!");
          bool2 = true;
          break;
        }
      }

      
      if (bool1 == true){continue;}
      if (bool2 == true){continue;}


      foreach (Team team2 in team){
        
        if (team2.NameGroup == command[1]){
          bool3 = true;
          break;
        }
      }

      if (!bool3){
        Console.WriteLine($"Team {command[1]} does not exist!");
        continue;
     }

      foreach (Team team2 in team){

        foreach(string member in team2.Members){

          if (member == command[0]){
            bool4 = true;
            break;
          }

        }

        if (bool4){break;}

      }

      if (bool4){
        Console.WriteLine($"Member {command[0]} cannot join team {command[1]}!");
        continue;
      }


      foreach(Team team2 in team){

        if (team2.NameGroup == command[1]){
          team2.Members.Add(command[0]);
          break;
        }

      }
    }

  List<Team> removed = new List<Team>();

  for (int i = 0; i < team.Count; i++){
    Team team2 = team[i];

    if (team2.Members.Count + 1 == 1){
      team.Remove(team2);
      removed.Add(team2);
    }
  }


  removed = removed.OrderBy(x => x.NameGroup).ToList();

  team = team.OrderBy(x => x.NameGroup).ToList();


  foreach(Team team2 in team){

    Console.WriteLine($"{team2.NameGroup}");
    Console.WriteLine($"- {team2.Creater}");
    foreach(string member in team2.Members){
      Console.WriteLine($"-- {member}");
    }
  }

  Console.WriteLine("Teams to disband:");

  foreach (Team team2 in removed){

    Console.WriteLine($"{team2.NameGroup}");
  }



  }
}



public class Team{

  public string Creater {get; set; }
  public string NameGroup {get; set; }

  public List<string> Members {get; set;}

  public Team(string creater, string nameGroup){
    this.Creater = creater;
    this.NameGroup = nameGroup;
    this.Members = new List<string>();
  }

}
