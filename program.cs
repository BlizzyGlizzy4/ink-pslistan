List<string> names = new List<string>();
List<int> prices = new List<int>();

names.Add("Mjölk");
prices.Add(15);

names.Add("Bröd");
prices.Add(32);

names.Add("Ost");
prices.Add(89);

int total = 0; 
for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine($"{i +1}. {names[i]} - {prices[i]} kr");
    total += prices[i];
}

Console.WriteLine($"Totalt: {total} kr");