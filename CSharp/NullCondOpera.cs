// Null conditional operatior - If we want to setup a mechanism where we want to verify whether value passed to variable is null or not and incase of null
// we should turn to default value which we have added/
// Here few basic variables are added and it will work with any data type that we have

namespace TestingNull
{
    class Program
    {
        public void Testing()
        {
            int? a = null;
            int b = a ?? -1;
            Console.WriteLine(b);
            string? x = null;
            string y = x ?? "default";
            Console.WriteLine(y);

            string? assignment = "Glitch";
            string newAssignment = assignment ?? "Gracesi";
            Console.WriteLine(newAssignment);
        }

        public static void Main(string[] args)
        {
            Program p = new Program();
            p.Testing();
        }
    }
}
