// Create Custom Exceptions that are not present by default.
// Create a custom class which inherits Exception class and define some functions which we want.

public class CustomException : Exception
{
    public CustomException()
    {
    }

    public CustomException(string message)
        : base(message)
    {
    }

    public CustomException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Some code that might raise the custom exception
            throw new CustomException("This is a custom exception message");
        }
        catch (CustomException ex)
        {
            Console.WriteLine("Custom exception occurred: " + ex.Message);
        }

        try
        {
            // Some code that might raise the custom exception
            throw new CustomException();
        }
        catch (CustomException ex)
        {
            Console.WriteLine("Custom exception occurred: " + ex.Message);
        }
    }
}
