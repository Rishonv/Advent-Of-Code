string line = "";
StreamReader sr = new StreamReader("./Input.txt");
List<List<int>> ElfCalories = new List<List<int>>();
ElfCalories.Add(new List<int>());

while (line != null)
{
    if (line.Length == 0)
    {
        ElfCalories.Add(new List<int>());
    }
    else
    {
        ElfCalories.Last().Add(Int32.Parse(line));
    }
    line = sr.ReadLine();
    Console.WriteLine(line);
}
sr.Close();

// List<int> sumElves= ElfCalories.ConvertAll(list => list.Sum());
// sumElves.OrderByDescending(l => l);
// Console.WriteLine("string %d %d %d", sumElves[0], sumElves[1],                                                     sumElves[2]);
Console.WriteLine(ElfCalories.ConvertAll(list => list.Sum()).OrderByDescending(l => l).Take(3).Sum());