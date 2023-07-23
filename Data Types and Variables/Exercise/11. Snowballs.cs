using System;

class Snowball
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double highestSnowballValue = double.MinValue;
        int bestSnowballSnow = 0;
        int bestSnowballTime = 0;
        int bestSnowballQuality = 0;

        for (int i = 0; i < n; i++)
        {
            int snowballSnow = int.Parse(Console.ReadLine());
            int snowballTime = int.Parse(Console.ReadLine());
            int snowballQuality = int.Parse(Console.ReadLine());

            double snowballValue = Math.Pow((snowballSnow / snowballTime), snowballQuality);

            if (snowballValue > highestSnowballValue)
            {
                highestSnowballValue = snowballValue;
                bestSnowballSnow = snowballSnow;
                bestSnowballTime = snowballTime;
                bestSnowballQuality = snowballQuality;
            }
        }

        Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {highestSnowballValue} ({bestSnowballQuality})");
    }
}
