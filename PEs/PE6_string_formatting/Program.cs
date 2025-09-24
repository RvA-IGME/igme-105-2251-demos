namespace PE6_string_formatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string title;
            string fullTitle;

            double money;

            
            Console.Write("What is your name? ");
            name = Console.ReadLine();
            Console.Write("What is an adjective that describes you? ");
            title = Console.ReadLine();

            fullTitle = string.Format("{0} the {1}", name, title);
            Console.WriteLine("Welcome, {0}!", fullTitle);
            
        }
    }
}
