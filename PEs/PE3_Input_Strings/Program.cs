namespace PE3_Input_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            string Name = Console.ReadLine();
            Name = Name.Trim();
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Welcome, " + Name + "!");
            Console.Write("What is your favorite color? ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            string Color = Console.ReadLine();
            Color = Color.Trim();
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("What is your pet's name? ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            string petName = Console.ReadLine();
            petName = petName.Trim();
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("What is your favorite band? ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            string BandName = Console.ReadLine();
            BandName = BandName.Trim();
            Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(); //Spacing
            Console.WriteLine("Your name is "+Name.Length+" letters long,");
            Console.WriteLine("which is "+(Name.Length - petName.Length)+" longer than "+petName+"'s name.");
        Console.WriteLine(); //Spacing
            Console.WriteLine("I wonder if " + petName + " likes " + BandName + " or the color " + Color + " too.");
        Console.WriteLine(); //Spacing
            string ZanyName = Name.ToUpper()[0] + Color.ToLower()[..2] + petName.ToLower()[..2] + BandName.ToLower()[..2];
            Console.WriteLine("Can I call you "+ZanyName+"? Or is that too on-the-nose?");
        }
    }
}
