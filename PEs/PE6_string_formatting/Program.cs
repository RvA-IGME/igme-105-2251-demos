using System.Runtime.InteropServices;

namespace PE6_string_formatting
{
    internal class Program
    {
        static void Main(string[] args)
        {

            const string StatUpdateLine = ("Current Stats - HP: {0}, Money: {1}");

            const string ActionPromptLine = ("What do you do next? ");
            const string ActionCostLine = ("How much HP will this take? ");
            const string ActionLine = ("You {0}, taking {1} hp.");
            
            const string ItemPromptLine = ("What item do you want to buy here? ");
            const string ItemCostLine = ("How much money does it cost? ");
            const string ItemLine = ("You buy {0}, spending ${1}.");

            const int BaseHealth = 100;

            string name;
            string title;
            string fullTitle;

            double health = 100;
            double money = 0;


            string action;
            double actionHealthCost;

            string item;
            double itemMoneyCost;
            double itemMoneyCostMarkup;

            Console.Write("What is your name? ");
            name = Console.ReadLine();
            Console.Write("What is a major adjective that describes you? ");
            title = Console.ReadLine();

            fullTitle = string.Format("{0} the {1}", name, title);
            Console.WriteLine("Welcome, {0}!", fullTitle);
            
        }
    }
}
