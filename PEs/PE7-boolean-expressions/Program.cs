namespace PE7_boolean_expressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string target;

            Console.Write("What does the golem detect?");
            target = Console.ReadLine();
            target = target.Trim();
            target = target.ToLower();

            if (target == "enemy")
            {
                Console.WriteLine("The golem takes aim and attacks.");
            }
            else
            if (target == "wall")
            {
                Console.WriteLine("The golem observes the wall for a while, then turns back.");
            }
            else
            if (target == "item")
            {
                Console.WriteLine("The golem observes the object, then picks it up.");
            }
            else 
            if (target == "door")
            {
                Console.WriteLine("The golem opens the door rather gracelessly and enters.");
            }

            else
            if (target == "shiro")
            {
                Console.WriteLine("The golem salutes the creature, and continues on.");
            }

            else
            if (target.Length > 0)
            {
                Console.WriteLine("The golem does not act.");
            }
            else
            {
                Console.WriteLine("The golem remains dormant.");
            }

        }
    }
}
