using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_MMO
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create Archer 
            //Items
            var archerItems = new List<Item>();
            var bow = new Item("Weapon","Langbogen",2500,1);
            var arrows = new Item("Weapon", "Pfeile", 10,100);
            var archerPotion = new Item("Item", "Heiltrank", 1000, 10);

            archerItems.Add(bow);
            archerItems.Add(arrows);
            archerItems.Add(archerPotion);

            //Character
            var archer = new Archer(183,65,archerItems,"Aragon",50,50,10,500);

            archer.CheckStats();




            //Create Tank 
            //Items
            var tankItems = new List<Item>();
            var axe = new Item("Weapon", "Knochenbrecher", 10000, 1);
            var axe2 = new Item("Weapon", "Schädelspalter", 15000, 1);
            var tankPotion = new Item("Item", "Heiltrank", 1000, 3);

            tankItems.Add(axe);
            tankItems.Add(axe2);
            tankItems.Add(tankPotion);

            //Character
            var tank = new Tank(170, 110, tankItems, "Arnold", 150, 75, 5, 1500);

            tank.CheckStats();


            // Create Warrior 
            //Items
            var warriorItems = new List<Item>();
            var sword = new Item("Weapon", "edler Einhänder", 25000, 1);
            var shield= new Item("Weapon", "Adanos Schutz", 5000, 1);
            var warriorPotion = new Item("Item", "Heiltrank", 1000, 5);

            warriorItems.Add(sword);
            warriorItems.Add(shield);
            warriorItems.Add(warriorPotion);

            //Character
            var warrior = new Tank(185, 90, warriorItems, "Thorus",100,100,8,1000);

            warrior.CheckStats();
            

            // Create Magician 
            //Items
            var magicianItems = new List<Item>();
            var magicStaff = new Item("Weapon", "Die heiligen 3 Plagen", 25000, 1);
            var magicianPotion = new Item("Item", "Heiltrank", 1000, 5);

            magicianItems.Add(magicStaff);
            magicianItems.Add(magicianPotion);

            //Character
            var magician = new Tank(150, 80, magicianItems, "Milten",75,150,8,1000);

            magician.CheckStats();

            // Create Healer
            //Items
            var healerItems = new List<Item>();
            var healerPotion = new Item("Item", "Heiltrank", 1000, 50);

            healerItems.Add(healerPotion);

            //Character
            var healer = new Tank(200, 75, healerItems, "Lares",0,100,10,1500);

            healer.CheckStats();

            Console.ReadKey();
        }
    }
}
