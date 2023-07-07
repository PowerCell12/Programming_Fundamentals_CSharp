using System;
partial class Program {
  public static void Main (string[] args) {

    List<Box> items = new List<Box>();


    while (true) {

      string[] data = Console.ReadLine().Split();

      if (data[0] == "end"){
        break;
      }


      double PriceOneBox =  double.Parse(data[2]) * double.Parse(data[3]);

      Box box = new Box(data[0], data[1], data[2], data[3], PriceOneBox);

      items.Add(box);
    }

    List<Box> SortedList = items.OrderBy(o=>o.Final).ToList();
    SortedList.Reverse();


    foreach (Box box in SortedList) {

      Console.WriteLine(box.SerialNumber);

      Console.WriteLine($"-- {box.Item} - ${box.PriceBox:F2}: {box.ItemQuantity}");

      Console.WriteLine($"-- ${box.Final:F2}");

    }




  }
}



public class Item{

  public string Name { set; get; }
  public string Price  { set; get; }


  public Item(string name1, string price1){
     Name = name1;
     Price = price1;
  }

}



public class Box
{
    public string SerialNumber { set; get; }
    public string Item { set; get; }
    public string ItemQuantity { set; get; }
    public double PriceBox { set; get; } // Changed the type to double
    public double Final { set; get; }

    public Box(string serialNumber, string item, string itemQuantity, string PriceBox1, double final1)
    {
        SerialNumber = serialNumber;
        Item = item;
        ItemQuantity = itemQuantity;
        PriceBox = double.Parse(PriceBox1); // Converted to double
        Final = final1;
    }
}
