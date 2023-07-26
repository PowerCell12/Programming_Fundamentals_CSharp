using System;
using System.Collections.Generic;
using System.Linq;

class Program {
  public static void Main (string[] args) {

    string filepath = Console.ReadLine();
    int counter = 0;
    int index = filepath.LastIndexOf(".");
    int index1 = filepath.LastIndexOf(@"\");
    
    for (int i = index1; i < index; i++){
      counter += 1;
    }
    
    string filename = filepath.Substring(index1 + 1, counter - 1);
    string extention  = filepath.Substring(index + 1);

    Console.WriteLine($"File name: {filename}");
    Console.WriteLine($"File extension: {extention}");
    
  }
}
