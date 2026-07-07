///*Given two strings s and t, return true if the two strings are anagrams of each other, otherwise return false.

//An anagram is a string that contains the exact same characters as another string, but the order of the characters can be different.

//Example 1:

//Input: s = "racecar", t = "carrace"

//Output: true
//Example 2:

//Input: s = "jar", t = "jam"

//Output: false*/

//bool isAnagram(string s, string t)
//{
//    Dictionary<char, int> tDictionary = new Dictionary<char, int>();
//    Dictionary<char, int> sDictionary = new Dictionary<char, int>();

//    if (s.Length != t.Length)
//    {
//        return false;
//    }

//    foreach(char c in t)
//    {
//        if (tDictionary.ContainsKey(c))
//        {
//            tDictionary[c] += 1;
//        }
//        else
//        {
//            tDictionary.Add(c, 1);
//        }

//        if (sDictionary.ContainsKey(c))
//        {
//            sDictionary[c] += 1;
//        }
//        else
//        {
//            sDictionary.Add(c, 1);
//        }
//    }

//    if (tDictionary.Count() == sDictionary.Count() && !tDictionary.Except(sDictionary).Any())
//    {
//        return true;
//    }

//    else
//    {
//        return false;
//    }
//}


//string sTestTrue = "bak";
//string tTestTrue = "tab";

//bool trueResult = isAnagram(sTestTrue, tTestTrue);

//Console.WriteLine(trueResult);
