// Tuples - Tuples are immutable that means whatever values are assigned can't be changed.
// Only operations we can do is creating and accessing

namespace Idkwhattonameit
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> one = new List<int> { 1, 2, 3 };
            int x = 2;
            string y = "Test";
            var testT = Tuple.Create(one, x, y);
            Console.WriteLine(testT.Item1);
            Console.WriteLine(testT.Item2);
            Console.WriteLine(testT.Item3);
        }
    }
}
