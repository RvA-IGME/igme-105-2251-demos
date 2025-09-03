namespace PE1_statements_expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name: " + "Rishi");
            Console.WriteLine(); //Spacing            
            Console.WriteLine("Vitality: " + 
                (50 * 0.23)         );
            Console.WriteLine("Armor: " + 
                ((50 * 0.23) / 2)   );
            Console.WriteLine("Agility: " + 
                (7)                 );
            Console.WriteLine("Defense: " + 
                (((50 * 0.23) / 2) + 
                7 - 
                2)                  );
            Console.WriteLine("Power: " + 
            (50 -(
                (50 * 0.23) +
                ((50 * 0.23) / 2) +
                7 +
                ((50 * 0.23) / 2) + 7 - 2)
            )                       );
            Console.WriteLine();
            Console.WriteLine("Stat Total: " + 50);
        }
    }
}
