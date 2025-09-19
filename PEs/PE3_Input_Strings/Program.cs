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
            string PetName = Console.ReadLine();
            PetName = PetName.Trim();
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("What is your favorite band? ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            string BandName = Console.ReadLine();
            BandName = BandName.Trim();
            Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(); //Spacing
            Console.WriteLine("Your name is "+Name.Length+" letters long,");
            Console.WriteLine("which is "+(Name.Length - PetName.Length)+" longer than "+PetName+"'s name.");
        Console.WriteLine(); //Spacing
            string ColorUpper = PetName.ToUpper();
            string PetNameUpper = PetName.ToUpper();
            string BandNameUpper = PetName.ToUpper();
            Console.WriteLine("I wonder if " + PetNameUpper + " likes " + BandNameUpper + " or the color " + ColorUpper + " too.");
        Console.WriteLine(); //Spacing
            string ZanyName = Name.ToUpper()[0] + Color.ToLower()[..2] + PetName.ToLower()[..2] + BandName.ToLower()[..2];
            Console.WriteLine("Can I call you "+ZanyName+"? Or is that too on-the-nose?");
        }
    }
}
