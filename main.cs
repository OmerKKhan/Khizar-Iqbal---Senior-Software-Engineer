using System;

//Task1
// Given an integer x, return true if x is palindrome integer.

// An integer is a palindrome when it reads the same backward as forward.

// For example, 121 is a palindrome while 123 is not.
//Example 1: 121
//Example 2: 2121
//Example 3: 2111
//Example 4: 123

class Program
{
    public static void Main(string[] args)
    {
      // Console.WriteLine(GetNumberOfDigits(12));
        Console.WriteLine(IsPalindrome(123));
        // Console.WriteLine(IsPalindrome(121));
        Console.WriteLine("Hello World");
    }

    public static int GetNumberOfDigits(int x)
    {
      if (x >= 0 && x <= 9) return 1;
      
        int numberOfDigits = 0;

        while (x > 0)
        {
          numberOfDigits++;
          x = x / 10;
        }

        return numberOfDigits;
    }

    public static bool IsPalindrome(int x)
    {
        int reverseNumber = 0;
        int originalNumber = x;
        int multiplier = (int)Math.Pow((long)10, (long)GetNumberOfDigits(x));

        while (originalNumber >= 0)
        {
            int reminder = originalNumber % 10;
            reverseNumber += (reminder * multiplier);

            Console.WriteLine($"reminder: {reminder}, reverseNumber: {reverseNumber}");

            if (originalNumber <= 9) break;

            originalNumber = originalNumber / 10; //1
            multiplier /= 10; //100

            Console.WriteLine($"originalNumber: {originalNumber}, multiplier: {multiplier}");
        }

        Console.WriteLine($"");
        Console.WriteLine($"");
        Console.WriteLine($"X: {x} Reverse: {reverseNumber}");

        return x == reverseNumber;

        /**
        number = (2 * 10) + 1;
        number = (1 * 1) + (2 * 10) + (3 * 100);

        org = 1 // expec = 321
          123 % 10 = 3
          123 /10 = 12
        12 % 10 = 2
        12 / 10 = 1
        < 9
        */
    }

// Task # 2
//You are given a function which takes an array of integers "seq" and an integer "target". There exist two elements of the array whose sum is equal to the target. You have to return the indices of those elements
//You can assume there is only one solution
// Example 1:

// Input: nums = [2,7,11,15], target = 9
// Output: [0,1]
// Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
// Example 2:

// Input: nums = [3,2,4], target = 6
// Output: [1,2]
// Example 3:

// Input: nums = [3,3], target = 6
// Output: [0,1]
      public static int[] TwoSum(int[] nums, int target) {
          //[1, 2, 3, 5, 7, 11, 15] target = 9
        // left = 0
        // right = 6
        // 1 + 7 = 8

        // Assuming it uses merge sort which gives us nLog(n)
        Array.Sort(nums);
        int leftIndex = 0;
        int rightIndex = nums.Length - 1;

        while (leftIndex < rightIndex)
        {
          int sum = nums[leftIndex] + nums[rightIndex];

          if (sum == target) return new[] { leftIndex, rightIndex };

          if (sum > target)
          {
            rightIndex--;
          }
          else
          {
            leftIndex++;
          }
        }

        return new[] { -1, -1 };
    }
}