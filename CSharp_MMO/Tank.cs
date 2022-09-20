using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_MMO
{
    public class Tank : Character
    {
        public Tank(int height, int weight, List<Item> items, string name, int damage, int armor, int speed, int health)
        {
            this.Height = height;
            this.Weight = weight;
            this.Items = items;
            this.Name = name;
            this.Damage = damage;
            this.Armor = armor;
            this.Speed = speed;
            this.Health = health;
        }
        public void UseArmor()
        {

        }

        public void TakeDamage()
        {

        }
    }
}
