// Threading - running methods concurrently/Paralley to save execution time
// Here I have added two simple methods to show how we can achieve threadding in csharp

namespace ThreaddingTest
{
    public class Program
    {
        static void SortArray1()
        {
            int[] array = { 2, 1, 3, 5, 4, 7, 6 };
            int[] newar = array.Distinct().ToArray();
            //int[] sorteAr = new int[newar.Length];
            for (int i = 0; i < newar.Length; i++)
            {
                for (int j = 0; j < newar.Length - i - 1; j++)
                {
                    int temp = 0;
                    if (newar[j] >= newar[j + 1])
                    {
                        temp = newar[j];
                        newar[j] = newar[j + 1];
                        newar[j + 1] = temp;
                    }
                }
            }
            foreach(int i in newar)
            {
                Console.WriteLine(i);
            }
        }

        static void IsPalind()
        {
            string str = "radar";
            int length = str.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (str[i] != str[length - i - 1])
                {
                    Console.WriteLine("False");
                }
            }
            Console.WriteLine("True");
        }

        static void Main(string[] args)
        {
	    //Object of thread
            Thread th1 = new Thread(SortArray1);
            Thread th2 = new Thread(IsPalind);
	    //to start the thread for execution
            th1.Start();
            th2.Start();
	    //If added main code will wait for thread to be executed.
            th1.Join();
            th2.Join();
            Console.WriteLine("Done");
        }
    }
}
