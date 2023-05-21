namespace Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! Welcome to pattern programming");
            MyPattern registrationPattern = new MyPattern();
            Console.WriteLine("EnterName");
            Console.WriteLine(registrationPattern.ValidateFirstName(Console.ReadLine()));

        }
    }
}