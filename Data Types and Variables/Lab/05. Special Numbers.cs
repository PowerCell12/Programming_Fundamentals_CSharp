int number = int.Parse(Console.ReadLine());
string sucess = "False";
int all = 0;

for (int i = 1; i <= number; i++)
{
    if (i > 9)   
    {
        string final = i.ToString();
        for (int k = 0; k < final.Length; k++)
        {
            char final1 = final[k];
            int final2 = final1 - '0';
            all += final2;
        }
        if (all == 5 || all == 11| all == 7)
        {
            sucess = "True";
        }
        else 
        {
            sucess = "False";
        }
        Console.WriteLine($"{i} -> {sucess}");
    }
    else
    {
        if (i == 5 || i == 11 || i == 7)
        {
            sucess = "True";
        }
        else
        {
            sucess = "False";
        }
        Console.WriteLine($"{i} -> {sucess}");
    }
    all = 0;
}
