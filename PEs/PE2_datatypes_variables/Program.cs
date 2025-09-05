namespace PE2_datatypes_variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string charName;
            int StatTotalPoints;
            double statVitality;
            double statArmor;
            double statAgility;
            double statDefense;
            double statPower;

            charName = "Rishi";
            StatTotalPoints = 50;
            statVitality = (StatTotalPoints * 0.23);
            statArmor = (statVitality / 2);
            statAgility = 7;
            statDefense = (statArmor + statAgility) - 2;
            statPower = (50 - statVitality - statArmor - statAgility - statDefense);

            Console.WriteLine("Name: " + charName);
            Console.WriteLine(); //Spacing   
            Console.WriteLine("Vitality: " + statVitality);
            Console.WriteLine("Armor: " + statArmor);
            Console.WriteLine("Agility: " + statAgility);
            Console.WriteLine("Defenses: " + statDefense);
            Console.WriteLine("Power: " + statPower);
            Console.WriteLine(); //Spacing   
            Console.WriteLine("Stat Total: " + StatTotalPoints);

        }
    }
}
