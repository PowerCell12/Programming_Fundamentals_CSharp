using System;
partial class Program {
  public static void Main (string[] args) {

    int numbersofSong  = int.Parse(Console.ReadLine());
    List<Song> songList = new List<Song>();


    for (int i = 0; i < numbersofSong; i++) {

      string[] data = Console.ReadLine().Split("_");

      Song song = new Song(data[0], data[1], data[2]);

      songList.Add(song);
    }


    string typeFinal = Console.ReadLine();


    if (typeFinal == "all") {

      foreach (Song song in songList) {

        Console.WriteLine(song.Name);

      }

    }
    else{

      foreach (Song song in songList) {

        if (song.Type_List == typeFinal) {
          Console.WriteLine(song.Name);
        }

      }

    }


  }
}


public class Song{

  public string Type_List { set; get; }
  public string Name { set; get; }
  public string Time { set; get; }

  public Song(string Type_List1, string Name1, string Time1){
    
    Type_List  = Type_List1;
    Name = Name1;
    Time = Time1;

  }

}
