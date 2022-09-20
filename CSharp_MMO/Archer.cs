using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_MMO
{
    public class Archer : Character 
    {
        public Archer(int height, int weight, List<Item> items, string name, int damage, int armor, int speed, int health, int maxHealth)
        {
            this.Height = height;
            this.Weight = weight;
            this.Items = items;
            this.Name = name;
            this.Damage = damage;
            this.Armor = armor;
            this.Speed = speed;
            this.Health = health;
            this.MaxHealth = maxHealth;
        }
        public new void DoDamageTo(Character doDamageTo)
        {
            for (int i = 0; i < this.Items.Count; i++)
            {
               
                if (this.Items[i].Name == "Pfeil" && this.Items[i].Amount > 0 && this.Items[i].KindOfItem == "Arrow")
                {
                    if (doDamageTo.Health > 0)
                    {
                        if (this.Damage > doDamageTo.Armor)
                        {
                            doDamageTo.Health -= this.Damage;
                            Console.WriteLine($"{this.Name} hat {doDamageTo.Name} erfolgreich angegriffen und {this.Damage} Schaden gemacht");
                            Console.WriteLine($"{doDamageTo.Name} HP: {doDamageTo.Health}");
                        }
                        else
                        {
                            Console.WriteLine($"{this.Name} hat {doDamageTo.Name} ohne Erfolg angegriffen");
                            Console.WriteLine($"{doDamageTo.Name} HP: {doDamageTo.Health}");
                        }
                        this.Items[i].ReduceAmount();
                    }
                    else
                    {
                        Console.WriteLine("der is doch schon tot?!");
                    }
                }
                else if (this.Items[i].KindOfItem == "Item" || this.Items[i].KindOfItem == "Weapon"|| this.Items[i].KindOfItem == "Potion" && this.Items[i].Name != "Arrow")
                {
                    // Do nothing 
                }
                else
                {
                    Console.WriteLine("Du hast leider keine Pfeile mehr! Du kannst entweder rennen oder deinen Bogen werfen");
                }
            }

        }

    }
}
