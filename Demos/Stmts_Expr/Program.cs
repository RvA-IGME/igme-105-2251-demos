namespace Stmts_Expr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello RIT!");
            Console.WriteLine();
            Console.WriteLine("Lorem ipsum dolor sit amet, consectetur adipiscing elit. " +
                "Proin bibendum purus ac aliquet venenatis. Cras ac iaculis urna. Maecenas" +
                " rutrum dui eu nibh volutpat faucibus. Donec fermentum massa quis rutrum gravida." +
                " Nunc nisl justo, aliquam nec dolor vitae, rutrum gravida ex. Morbi suscipit nisi" +
                " eget nisl blandit tempor. Donec feugiat porttitor nisl, non rutrum ipsum vulputate" +
                " eget. Ut condimentum nunc quis ullamcorper lobortis. Lorem ipsum dolor sit amet, " +
                "consectetur adipiscing elit. Etiam tempor nulla vitae purus feugiat, ac tristique " +
                "mi sollicitudin. Pellentesque facilisis ante non vulputate pellentesque. Vivamus " +
                "auctor dui ac nulla lacinia, et ultrices dui malesuada. Proin lobortis nisi vel" +
                " diam facilisis, id feugiat odio mattis.");

            Console.WriteLine();
            Console.Clear();
            Console.Write("This ");
            Console.Write("is ");
            Console.Write("one ");
            Console.WriteLine("line.");
            Console.WriteLine(":)");

            // "hello" + " " + "world";
            Console.WriteLine("hello" + " " + "world");

            // 6 + 3;
            Console.WriteLine(6 + 3);

            Console.WriteLine(25 % 5); // 25 mod 5 --> 0

            Console.WriteLine("Min/day: " + (24 * 60));
            Console.WriteLine("Min/day: " + 24 * 60);

            Console.WriteLine("six + three: " + 9);
            Console.WriteLine("six + three: " + 6 + 3);
            Console.WriteLine("six + three: " + (6 + 3));
        }
    }
}
