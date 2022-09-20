using System;
using System.Collections.Generic;

namespace CSharp_MMO
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Create Archer "aragon"
            //Items
            var archerItems = new List<Item>();
            var bow = new Item("Weapon", "Langbogen", 2500, 1);
            var arrows = new Item("Arrow", "Pfeil", 10, 100);
            var archerPotion = new Item("Potion", "Heiltrank", 1000, 10);

            archerItems.Add(bow);
            archerItems.Add(arrows);
            archerItems.Add(archerPotion);

            //Character
            var aragon = new Archer(183, 65, archerItems, "Aragon",75, 50, 10, 350,500);

            aragon.CheckStats();
            #endregion

            #region Create Tank "arnold"
            //Items
            var tankItems = new List<Item>();
            var axe = new Item("Weapon", "Knochenbrecher", 10000, 1);
            var axe2 = new Item("Weapon", "Schädelspalter", 15000, 1);
            var tankPotion = new Item("Potion", "Heiltrank", 1000, 3);

            tankItems.Add(axe);
            tankItems.Add(axe2);
            tankItems.Add(tankPotion);

            //Character
            var arnold = new Tank(170, 110, tankItems, "Arnold", 150, 75, 5, 1500,1500);

            arnold.CheckStats();
            #endregion

            #region Create Warrior "thorus"
            //Items
            var warriorItems = new List<Item>();
            var sword = new Item("Weapon", "edler Einhänder", 25000, 1);
            var shield = new Item("Weapon", "Adanos Schutz", 5000, 1);
            var warriorPotion = new Item("Potion", "Heiltrank", 1000, 5);

            warriorItems.Add(sword);
            warriorItems.Add(shield);
            warriorItems.Add(warriorPotion);

            //Character
            var thorus = new Warrior(185, 90, warriorItems, "Thorus", 100, 100, 8, 1000,1000);

            thorus.CheckStats();
            #endregion

            #region Create Magician "milten"
            //Items
            var magicianItems = new List<Item>();
            var magicStaff = new Item("Weapon", "Die heiligen 3 Plagen", 25000, 1);
            var magicianPotion = new Item("Potion", "Heiltrank", 1000, 5);

            magicianItems.Add(magicStaff);
            magicianItems.Add(magicianPotion);

            //Character
            var milten = new Magician(150, 80, magicianItems, "Milten",75, 150, 8, 500,1000);

            milten.CheckStats();
            milten.UsePotion();
            #endregion

            #region Create Healer "lares"
            //Items
            var healerItems = new List<Item>();
            var healerPotion = new Item("Potion", "Heiltrank", 1000, 50);

            healerItems.Add(healerPotion);

            //Character
            var lares = new Healer(200, 75, healerItems, "Lares", 0, 100, 10, 1500,1500);

            lares.CheckStats();
            #endregion

            #region ACTIONS: Heal | DoDamageTo | UsePotion
            lares.Heal(aragon);
            aragon.DoDamageTo(arnold);
            arnold.DoDamageTo(lares);
            #endregion


            Console.ReadKey();
        }
    }
}
