using System;

public class MergeNames
{
    public static string[] UniqueNames(string[] names1, string[] names2)
    {
        var set1 = new HashSet<string>(names1);
        var set2 = new HashSet<string>(names2);
        var result = new HashSet<string>(set1);
        foreach (var name in set2)
            result.Add(name);
        return result.ToArray();
    }

    public static void Main(string[] args)
    {
        string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
        string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
        Console.WriteLine(string.Join(", ", UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
    }
}