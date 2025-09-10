namespace PE3_math_casting_documentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.1415926535897931;
            string playerName = "SirGalindo";

            int Point1x = -13;
            int Point1y = 51;

            int Point2x = 17;
            int Point2y = 28;

            int hours = 274;

            double numA = 7.9;
            double numB = 2.25;

            double angleDeg = 60;
            double angleRad = (angleDeg * (PI / 180));

            Console.WriteLine("Number A: " + numA);
            Console.WriteLine("Number B: " + numB);
            Console.WriteLine(numA + " + " + numB + " = " + (numA + numB));
            Console.WriteLine("Now:");
            Console.WriteLine((int)numA + " + " + (int)numB + " = " + ((int)numA + (int)numB));

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
