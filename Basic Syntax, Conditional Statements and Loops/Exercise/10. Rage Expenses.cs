int lostGames = int.Parse(Console.ReadLine());
double price_headset = double.Parse(Console.ReadLine());
double price_mouse = double.Parse(Console.ReadLine());
double price_keyboard = double.Parse(Console.ReadLine());
double price_monitor = double.Parse(Console.ReadLine());
int countHeadset = 0;
int countMouse = 0;
int countKeyboard = 0;
int countMonitor = 0;
int different = 0;

for (int i = 1; i <= lostGames; i++)
{
  if (i % 2 == 0)
  {
    countHeadset++;
  }

  if (i % 3 == 0)
  {
    countMouse++;
  }

  if (i % 2 == 0 && i % 3 == 0)
  {
    countKeyboard++;
  }

  if (countKeyboard % 2 == 0 && countKeyboard != different)
  {
    different = countKeyboard;
    countMonitor++;
  }
}

double final = price_headset * countHeadset + price_mouse * countMouse + price_keyboard * countKeyboard + price_monitor * countMonitor;

Console.WriteLine($"Rage expenses: {final:F2} lv.");
