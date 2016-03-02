using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Comparator c = new Comparator();
            c.addItem("Attack 80");
            c.addItem("Constitution 79");
            c.addItem("Mining 55");
            c.addItem("Strength 76");
            c.addItem("Agility 45");
            c.addItem("Smithing 48");
            c.addItem("Defense 81");
            c.addItem("Herblore 22");
            c.addItem("Fishing 65");
            c.addItem("Ranged 67");
            c.addItem("Thieving 48");
            c.addItem("Cooking 54");
            c.addItem("Prayer 55");
            c.addItem("Crafting 53");
            c.addItem("Firemaking 42");
            c.addItem("Magic 74");
            c.addItem("Fletching 58");
            c.addItem("Woodcutting 87");
            c.addItem("Runecrafting 56");
            c.addItem("Slayer 55");
            c.addItem("Farming 50");
            c.addItem("Construction 67");
            c.addItem("Hunter 32");
            c.addItem("Summoning 38");
            c.addItem("Dungeoneering 65");
            c.addItem("Divination 25");
            c.addItem("Invention 1");

            c.run();
            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadKey();
        }
    }
}
