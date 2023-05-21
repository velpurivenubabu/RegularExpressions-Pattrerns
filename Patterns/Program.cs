namespace Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! Welcome to pattern programming");
            MyPattern registrationPattern = new MyPattern();
            Console.WriteLine("Enter First Name");
            Console.WriteLine(registrationPattern.ValidateFirstAndLastName((Console.ReadLine())));
            Console.WriteLine("Enter Last Name");
            Console.WriteLine(registrationPattern.ValidateFirstAndLastName((Console.ReadLine())));
            Console.WriteLine("Enter  Email");
            Console.WriteLine(registrationPattern.ValidateEmailName(Console.ReadLine()));

        }
    }
}