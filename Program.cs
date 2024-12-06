string[] lines = File.ReadAllLines("day1inputdata.txt");

List<int> leftValues = new List<int>();
List<int> rightValues = new List<int>();


foreach (string line in lines)
{
    string[] parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

    if (parts.Length >= 2 && !string.IsNullOrEmpty(parts[1]))
    {
        int left = int.Parse(parts[0]);
        leftValues.Add(left);

        int right = int.Parse(parts[1]);
        rightValues.Add(right);

    }
      
}

leftValues.Sort();
rightValues.Sort();


//created a list of pairs to store the results for later use.
List<(int left, int right)> pairs = new List<(int, int)>();
for (int i = 0; i < leftValues.Count; i++)
{
    pairs.Add((leftValues[i], rightValues[i]));
}

foreach (var pair in pairs)
{
    int difference = Math.Abs(pair.left - pair.right);
    Console.WriteLine($" {pair.left}, {pair.right}: {difference}");
}

int totalDistance = pairs.Sum(pair => Math.Abs(pair.left - pair.right));
Console.WriteLine($"Total distance: {totalDistance}");


