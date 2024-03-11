//Task - another way to achieve concurrency/asynchronous/parallel execution to reduce execution time.
//Includes basic structure on how we can setup a task

namespace TaskTest
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
            foreach (int i in newar)
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
        
        static async Task Main(string[] args)
        {
            //Two ways to start task - 1st
            Task task1 = Task.Run(SortArray1);
            Task task2 = Task.Run(IsPalind);
            await Task.WhenAll(task1, task2);

            //2nd
            //Await will wait till all the tasks are executed before moving to main method.
            await Task.WhenAll(
                Task.Factory.StartNew(SortArray1),
                Task.Factory.StartNew(IsPalind)
                );

            Console.WriteLine("Done");
        }
    }
}
