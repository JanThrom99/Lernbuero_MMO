using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_MMO
{
    public abstract class Character
    {
        public int Height;
        public int Weight;
        public List<Item> Items;
        public string Name;
        public int Damage;
        public int Armor;
        public int Speed;
        public int Health;

        public void DoDamage()
        {

        }

        public void CheckStats()
        {
            Console.WriteLine("\n" + "\n");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine($"Name: {this.Name}\n Armor: {this.Armor}\n Health: {this.Health}");
            Console.WriteLine("Items: ");
            foreach (var item in this.Items)
            {
                Console.WriteLine($"- {item.KindOfItem} | {item.Name} | Cost: {item.Cost} | Amount: {item.Amount}");
            }
            Console.WriteLine("-----------------------------------------------------------------------");
        }
    }
}
