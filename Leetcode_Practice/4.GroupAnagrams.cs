///*
// Given an array of strings strs, group all anagrams together into sublists. You may return the output in any order.

//An anagram is a string that contains the exact same characters as another string, but the order of the characters can be different.

//Example 1:

//Input: strs = ["act","pots","tops","cat","stop","hat"]

//Output: [["hat"],["act", "cat"],["stop", "pots", "tops"]]
//Example 2:

//Input: strs = ["x"]

//Output: [["x"]]
//Example 3:

//Input: strs = [""]

//Output: [[""]]
// */

//List<List<string>> GroupAnagrams(string[] strs)
//{
//    var result = new Dictionary<string, List<string>>();
//    foreach (string str in strs)
//    {
//        int[] count = new int[26];
//        foreach (char c in str)
//        {
//            count[c - 'a']++;
//        }
//        string key = string.Join(',', count);

//        if (!result.ContainsKey(key))
//        {
//            result[key] = new List<string>();
//        }
//        result[key].Add(str);
//    }

//    return result.Values.ToList<List<string>>();
//}

//string[] strs = ["act", "pots", "tops", "cat", "stop", "hat"];

//var result = GroupAnagrams(strs);

//foreach (var resArr in result)
//{
//    foreach (var res in resArr)
//    {
//        Console.WriteLine(res);
//    }
//}