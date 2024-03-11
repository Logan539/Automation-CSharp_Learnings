// Rotate an array using k position. 
// It might be a wrong way or it will need some improvment but this is how I have done.

namespace DSA
{
    class Program
    { 
        public int[] RotateArray(int[] array, int k)
        {
            int[] result = new int[array.Length];
            int j = 0;
            for (int i = array.Length - 1; i>=0; i--)
            { 
                result[j] = array[i];
                if(j >= k)
                {
                    for(int l = 0; l < array.Length-k; l++)
                    {
                        result[j] = array[l];
                        j++;
                    }
                    break;
                }
                j++;
            }
            foreach(var i in result)
            {
                Console.WriteLine(i);
            }
            return result;
        }

        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            int k = 3;
            Program p = new Program();
            p.RotateArray(nums, k);
        }
    }
}
