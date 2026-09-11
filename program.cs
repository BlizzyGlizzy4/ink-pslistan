using System.Numerics;

List<string> names = new List<string>();
List<int> prices = new List<int>();

names.Add("Mjölk");
prices.Add(15);

names.Add("Bröd");
prices.Add(32);

names.Add("Ost");
prices.Add(89);

while (true)
{
    int total = 0;
    for (int i = 0; i < names.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {names[i]} - {prices[i]} kr");
        total = total + prices[i];
    }
    Console.WriteLine($"Totalt: {total} kr");

    string input = Console.ReadLine();
    if (int.TryParse(input, out int position))
    {
        Console.WriteLine($"Du vill ta bort vara nummer {position}");
    }
    else
    {
        Console.WriteLine($"Du vill lägga till en ny vara: {input}");
    }
}