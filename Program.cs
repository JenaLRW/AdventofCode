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

for (int i = 0; i < leftValues.Count; i++)
{
Console.WriteLine($"{leftValues[i]}  {rightValues[i]}");
}


