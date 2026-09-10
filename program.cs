List<string> names = new List<string>();
List<int> prices = new List<int>();

names.Add("Mjölk");
prices.Add(15);

names.Add("Bröd");
prices.Add(32);

names.Add("Ost");
prices.Add(89);

Console.WriteLine($"{names[0]} - {prices[0]} kr");
Console.WriteLine($"{names[1]} - {prices[1]} kr");
Console.WriteLine($"{names[2]} - {prices[2]} kr");
Console.WriteLine($"Totalpris: {prices[0] + prices[1] + prices[2]} kr");