using System;
partial class Program {  
  public static void Main (string[] args)
    {

        int length = int.Parse(Console.ReadLine());
        int[] values = new int[length];

        if (length == 1){
          Console.WriteLine("1");
        }
        else if  (length == 2){
          Console.WriteLine("1 1");
        }
        else{
          values[0] = 1;
          values[1] = 1;
          values[2] = 2;

          Tribonacci(length, values);
        }

    }

    static void Tribonacci(int length, int[] values)
    {
        for (int i = 3; i < length; i++)
        {

            values[i] = values[i - 1] + values[i - 2] + values[i - 3];
        }

        foreach (int i in values)
        {
            Console.Write($"{i} ");

        }
    }
}
