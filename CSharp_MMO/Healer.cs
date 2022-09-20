using System;
using System.Collections.Generic;

namespace CSharp_MMO
{
    public class Healer : Character
    {
        public Healer(int height, int weight, List<Item> items, string name, int damage, int armor, int speed, int health, int maxHealth)
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
        public void Heal(Character otherPlayer)
        {
            if (otherPlayer.MaxHealth != otherPlayer.Health)
            {
                for (int j = 0; j < this.Items.Count; j++)
                {
                    if (this.Items[j].Name == "Heiltrank" && this.Items[j].Amount > 0)
                    {
                        for (int i = 0; i < otherPlayer.Items.Count; i++)
                        {
                            if (otherPlayer.Items[i].Name == "Heiltrank" && this.Items[j].KindOfItem == "Potion")
                            {
                                otherPlayer.Items[i].IncreaseAmount(); 
                                this.Items[j].ReduceAmount();
                                Console.WriteLine("Hier hast du NOCH einen Heiltrank du Gierschlund! ");
                            }
                            else if (otherPlayer.Items[i].KindOfItem == "Item" || otherPlayer.Items[i].KindOfItem == "Weapon" || otherPlayer.Items[i].KindOfItem == "Arrow")
                            {
                                // Do nothing 
                            }
                            else
                            {
                                this.Items[j].ReduceAmount();
                                otherPlayer.Items.Add(new Item("Item", "Heiltrank", 1000, 1));
                                Console.WriteLine("Du hast jetzt einen Heiltrank! Benutz ihn oder STIRB!");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine(
                            "Du hast leider keine Heiltränke mehr! ab jetzt bist du nur noch unnötige Last für dein Team");
                    }
                }
            }
            else
            {
                Console.WriteLine("du brauchst keine Heilung schwirr ab!");
            }
        }
    }
}
