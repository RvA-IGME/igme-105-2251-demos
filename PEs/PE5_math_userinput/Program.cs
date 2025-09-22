namespace PE5_math_userinput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.1415926535897931;
            string playerName; // = "SirGalindo";

            double Point1x; // = -13;
            double Point1y; // = 51;

            double Point2x; // = 17;
            double Point2y; // = 28;

            int hours = 274;

            double numA; // = 7.9;
            double numB; // = 2.25;

            double angleDeg; // = 60;
            double angleRad; // = (angleDeg * (PI / 180));

            Console.WriteLine("--Addition:--");
            Console.Write("What is the first number? ");
            numA = double.Parse(Console.ReadLine());
            Console.Write("What is the second number? ");
            numB = double.Parse(Console.ReadLine());
            Console.WriteLine("The Full Numbers Together: " + numA + " + " + numB + " = " + (numA + numB));
            Console.WriteLine("As Ints Only: " + (int)numA + " + " + (int)numB + " = " + ((int)numA + (int)numB));

            Console.WriteLine("--Division / Modulus:--");
            Console.Write("What is the player's name?");
            playerName = Console.ReadLine();
            Console.WriteLine("How many hours have they logged?");
            hours = int.Parse(Console.ReadLine());
            Console.WriteLine(playerName + " has played the game for " + hours + " hours.");
            Console.WriteLine("This totals " + ((hours - (hours % 24)) / 24) + " days and " + (hours % 24) + " hours.");

            Console.WriteLine("--Sine / Cosine:--");
            Console.Write("Enter an angle in degrees:");
            angleDeg = double.Parse(Console.ReadLine());
            angleRad = (angleDeg * (PI / 180));
            Console.WriteLine(angleDeg + " degrees is " + angleRad + " radians.");
            Console.WriteLine("The Sine of the angle is " );

            Console.WriteLine("--Distance:--");
            Console.Write("Enter Point 1's X: ");
            Point1x = double.Parse(Console.ReadLine());
            Console.Write("Enter Point 1's Y: ");
            Point1y = double.Parse(Console.ReadLine());
            Console.Write("Enter Point 2's X: ");
            Point2x = double.Parse(Console.ReadLine());
            Console.Write("Enter Point 2's Y: ");
            Point2y = double.Parse(Console.ReadLine());

            Console.WriteLine($"Point One: {Point1x}, {Point1y}");
            Console.WriteLine($"Point Two: {Point2x}, {Point2y}");
            Console.WriteLine($"");
        }
    }
}
