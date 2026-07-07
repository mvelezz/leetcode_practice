///*Given an integer array nums, return true if any value appears more than once in the array, otherwise return false.*/


//bool ContainsDuplicate(int[] nums)
//{
//    List<int> checker = new List<int>();

//    foreach(int num in nums)
//    {
//        if (checker.Contains(num))
//        {
//            return true;
//        }
//        else
//        {
//            checker.Add(num);
//        }
//    }
//    return false;

//}

//int[] falseTest = { };

//int[] trueTest = { 2, 2, 3, 3, 4, 4, 4, 4,};

//bool falseResult = (ContainsDuplicate(falseTest));

//bool trueResult = (ContainsDuplicate(trueTest));

//Console.BackgroundColor = ConsoleColor.Red;

//Console.WriteLine($"False Result {falseResult}");

//Console.BackgroundColor = ConsoleColor.Green;

//Console.WriteLine($"True Result {trueResult}");

//Console.BackgroundColor = ConsoleColor.Black;
