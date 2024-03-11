// LINQ Query - short queries that you can use to query around data such as collections, xml, SQL database.
// Below are just basic stuff and we can do much more with it.

namespace LinqQueries
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] valuesSort = { 42, 15, 73, 68, 24, 91, 10, 56, 37, 82 };
            string[] strings = { "apple", "banana", "orange", "grape", "kiwi", "apple" };

            //Sort values using LINQ
            var SortedValues = from val in valuesSort
                               orderby val
                               select val;
                               //valuesSort.OrderBy(x => x);

            foreach (var value in SortedValues)
            {
                Console.WriteLine(value);
            }

            var newStrings = strings.Distinct();
            foreach (var value in newStrings)
            {
                Console.WriteLine($"{value}");
            }

            var new1 = from str in newStrings
                       where str != "apple" && str!= "grape"
                       select str;

            foreach(var value in new1)
            {
                Console.WriteLine(value);
            }

            int[] araytoSort = { 2, 1, 5, 4, 3 };
            var x = from i in araytoSort
                    orderby i
                    select i;

            foreach(var value in x)
            {
                Console.WriteLine(value);
            }
        }
    }
}
