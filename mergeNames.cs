using System;
using System.Collections.Generic;

public class MergeNames
{
    public static string[] UniqueNames(string[] names1, string[] names2)
    {
        HashSet<string> nameSet = new HashSet<string>();
        
        for (int i = 0; i < names1.Length; i++){
            nameSet.Add(names1[i]);
        }
        for (int j = 0; j < names2.Length; j++){
            nameSet.Add(names2[j]);
        }
        
        string[] mergedArr = new string[nameSet.Count];
        nameSet.CopyTo(mergedArr);
        return mergedArr;
         
        throw new NotImplementedException();
    }
    
    public static void Main(string[] args)
    {
        string[] names1 = new string[] {"Ava", "Emma", "Olivia"};
        string[] names2 = new string[] {"Olivia", "Sophia", "Emma"};
        Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
    }
}