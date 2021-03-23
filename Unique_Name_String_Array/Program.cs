
using System;
using System.Linq;

public class MergeNames
{
	public static string[] UniqueNames(string[] names1, string[] names2)
	{
		var allnames = names1.Union(names2).ToArray();

		string[] distinctnames = allnames.Distinct(StringComparer.CurrentCultureIgnoreCase).ToArray();

		Array.Sort(distinctnames, StringComparer.InvariantCulture);
		
		return distinctnames;

	}
	public static void Main(string[] args)
	{
		string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
		string[] names2 = new string[] { "Olivia", "Sophia", "Emma", "ava" };
		Console.WriteLine(string.Join(", ", UniqueNames(names1, names2))); 
	}
}
