using System;
partial class Program {  
  public static void Main (string[] args)
    {

      List<double> list1 = Console.ReadLine().Split().Select(double.Parse).ToList();
      List<double> list2 = Console.ReadLine().Split().Select(double.Parse).ToList();
      List<double> final = new List<double>();
      int length = 0;

      if (list1.Count <= list2.Count){
          length = list1.Count;
      }
      else if  (list2.Count < list1.Count){
        length = list2.Count;
      }

      for (int i = 0; i < length; i++){

        final.Add(list1[i]);
        final.Add(list2[i]);
      }

      if (list1.Count > length){

        for (int i = length; i < list1.Count; i++) {
          final.Add(list1[i]);
        } 

      }
      else if (list2.Count > length){

        for (int i = length; i < list2.Count; i++) {
          final.Add(list2[i]);

        }
      }

      Console.WriteLine(string.Join(" ", final));


    }

}
