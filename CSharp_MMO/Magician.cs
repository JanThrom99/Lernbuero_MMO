using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_MMO
{
    public class Magician : Character
    {

        public Magician(int height, int weight, List<Item> items, string name, int damage, int armor, int speed, int health, int maxHealth)
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
    }
}
