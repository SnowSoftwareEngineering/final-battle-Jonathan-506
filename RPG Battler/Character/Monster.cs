using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Battler.Character
{
    public class Monster : Creations
    {
        public int Health { get; set; }
        public int Power { get; set; }
        public int Luck { get; set; }
        public int Mana { get; set; }
        public int DropExperience { get; set; }
        public CreatureRarity CreatureRarity { get; set; }

        public void DisplayStats(bool showWithEquipment = false)
        {
            if (showWithEquipment)
            {
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Level: {Level}");
                Console.WriteLine($"Health: {TotalHealth}");
                Console.WriteLine($"Power: {TotalPower}");
                Console.WriteLine($"Luck: {TotalLuck}");

            }
            else
            {
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Level: {Level}");
                Console.WriteLine($"Health:{Health}");
                Console.WriteLine($"Power: {Power}");
                Console.WriteLine($"Luck: {Luck}");
            }
        }
        public Monster() {
            Random random = new Random();
            Name = "Unknown Beast";
            Level = random.Next(5, 15);
            PowerLevel(Level);
            int number = random.Next(1, 101);
            if( number == 1){
                CreatureRarity = CreatureRarity.Legendary;
            } else if (number < 10){
                CreatureRarity = CreatureRarity.Heroic;
            } else if (number < 30){
                CreatureRarity = CreatureRarity.Rare;
            } else {
                CreatureRarity = CreatureRarity.Common;
            }
        }

        public void PowerLevel(int heroLevel)
        {
            for (int i = 0; i < heroLevel; i++)
            {
                LevelUp();
            }
        }

        public void LevelUp()
        {
            Random random = new Random();


            switch (CreatureRarity)
            {
                case CreatureRarity.Common:
                    Health += random.Next(2, 11);
                    Power += 2;
                    Luck += random.Next(1, 4);
                    break;
                case CreatureRarity.Rare:
                    Health += random.Next(10, 14);
                    Power += random.Next(3, 5);
                    Luck += random.Next(3, 6);
                    break;
                case CreatureRarity.Heroic:
                    Health += random.Next(12, 21);
                    Power += random.Next(3, 6);
                    Luck += random.Next(3, 8);
                    break;
                case CreatureRarity.Legendary:
                    Health += random.Next(20, 41);
                    Power += random.Next(5, 13);
                    Luck += random.Next(10, 21);
                    break;
                default:
                    Health += 1;
                    Power += 1;
                    Luck += 1;
                    break;
            }

        }
        
    }
    public enum CreatureRarity
{
    Common,
    Rare,
    Heroic,
    Legendary
}

}
