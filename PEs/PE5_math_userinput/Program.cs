namespace PE5_math_userinput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.1415926535897931;
            string playerName = "SirGalindo";

            double Point1x = -13;
            double Point1y = 51;

            double Point2x = 17;
            double Point2y = 28;

            int hours = 274;

            double numA = 7.9;
            double numB = 2.25;

            double angleDeg = 60;
            double angleRad = (angleDeg * (PI / 180));

            Console.Write("Enter Point 1's X: ");
            Point1x = double.Parse(Console.ReadLine());
            Console.Write("Enter Point 1's Y: ");
            Point1y = double.Parse(Console.ReadLine());
            Console.Write("Enter Point 2's X: ");
            Point2x = double.Parse(Console.ReadLine());
            Console.Write("Enter Point 2's Y: ");
            Point2y = double.Parse(Console.ReadLine());

            Console.WriteLine("--Distance:--");
            Console.WriteLine($"Point One: {Point1x}, {Point1y}");
            Console.WriteLine($"Point Two: {Point2x}, {Point2y}");
            Console.WriteLine($"");
        }
    }
}
