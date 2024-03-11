// Interface callings

namespace InterfaceTest
{
  // Two interface classes
    public interface Iface
    {
        void Paint();
    }
    public interface Iaction
    {
        void Paint();
    }

  // Interface inherited
    public class Program : Iface, Iaction
    {
      void Iface.Paint()
      {
        Console.WriteLine("Do something.");
      }
      void Iaction.Paint()
      {
        Console.WriteLine("Don not");
      }

      static void Main(string[] args)
      {
          // Explicit interface calling
            Program p = new Program();
            Iface iface = p;
            Iaction iaction = p;
            iface.Paint();
            iaction.Paint();
      }
    }
}
