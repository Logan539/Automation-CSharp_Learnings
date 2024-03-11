// Ref and Out keyword - When ref keyword is used whatever execution happens on a function where it is passed as a argument, change in value in that function will change the original value.
// For e.g. if we have a int y = 10 and we pass it to function dosom(ref y), whatever execution will happen it will change the value of y according to execution.
// Out keyword - in ref we need to assign some value but in out we just need to declare variable. Then whatever execution happens accordingly value will get assigned to it. We can use this in case we want to have function return multiple values.
// For e.g. if we have a bool x, and we pass it to function DoSome(out x), whatever value will be returned will be assigned to x and same way we can return multiple values.

namespace RefAndOut
{
    public class Program
    {
        public void refTest(ref int x)
        {
            x = x * x;
        }

        public void outTest(out int x, out bool z)
        {
            x = 20;
            z = true;
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            int y = 10;
            bool z;
            p.refTest(ref y);
            Console.WriteLine(y);
            p.outTest(out y, out z);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
