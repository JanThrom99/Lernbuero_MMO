using System;
using System.Collections.Generic;

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
        public int MaxHealth;

        public void DoDamageTo(Character doDamageTo)
        {
            if (doDamageTo.Health>0)
            {
                if (this.Damage > doDamageTo.Armor)
                {
                    doDamageTo.Health -= this.Damage;
                    Console.WriteLine($"{this.Name} hat {doDamageTo.Name} erfolgreich angegriffen und {this.Damage} Schaden gemacht");
                    Console.WriteLine($"{doDamageTo.Name} HP: {doDamageTo.Health}");
                }
            }
            else
            {
                Console.WriteLine("der is doch schon tot?!");
            }

        }

        public void UsePotion()
        {
            if (this.MaxHealth != this.Health)
            {
                foreach (var item in this.Items)
                {
                    if (item.Name == "Heiltrank" && item.Amount > 0)
                    {
                        this.Health += 100;
                        item.Amount -= 1;
                        Console.WriteLine($"du wurdest geheilt! \n HP: {this.Health} \n Anzahl Heiltränke: {item.Amount}");
                    }
                }
            }
            else
            {
                Console.WriteLine("du musst keinen Heiltrank nehmen");
            }
            
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
