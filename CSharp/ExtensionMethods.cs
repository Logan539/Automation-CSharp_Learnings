// Extension Methods - We might have seen some default functions after declaring any variable and writing . which will open up bunch of different methods.
// Extension methods are nothing but we can create a customized functions that can be accessed with . after any variable.
// To use it we need static class with static methods in it. We can either call it in a same class file or in a different project itself. 
// If we are using different project them we just need to add its reference and add using in the file

using ExtensionFunctions2; // Project file which is different having extension methods added

namespace MyTest3
{

    public static class StringExtensions
    {
        // Define a static method within the class
        public static bool IsPalindrome(this string str)
        {
            // Implement the functionality of the extension method
            int length = str.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (str[i] != str[length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsSame(this string str1)
        {
            string xy = "Logan";
            if(xy !=  str1)
            {
                return false;
            }
            return true;
        }
    }

    public class Program
    {
        static async Task Main(string[] args)
        {
            string wordToCheck = "radar";
            Console.WriteLine(wordToCheck.IsPalindrome());
            int[] arrayL = { 3, 4, 4, 2, 6, 8, 7 };
            var x = arrayL.SortArray();
            foreach (int num in x)
            {
                Console.WriteLine(num);
            }
            string nameI = "Logan";
            Console.WriteLine(nameI.IsSame());
        }
    }
}
