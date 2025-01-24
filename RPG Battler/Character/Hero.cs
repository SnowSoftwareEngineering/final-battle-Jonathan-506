using RPG_Battler.Character.Upgrades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Battler.Character
{
    public class Hero : Creations
    {
        public int Health { get; set; }
        public int Power { get; set; }
        public int Luck { get; set; }
        public int Mana { get; set; }
        public int ExperienceRemaining { get; set; }
        public CombatClass CombatClass { get; set; }
        public List<Item> Items { get; set; }
        public List<Equipment> Equipment { get; set; }

        public Hero()
        {
            Name = "Unkown";
            Level = 0;
            Health = 1;
            Power = 1;
            Luck = 1;
            Mana = 1;
        }

        public void LevelUp()
        {
            Random random = new Random();
            

            switch (CombatClass)
            {
                case CombatClass.Warrior:
                    Health += random.Next(10, 21);
                    Power += random.Next(1, 4);
                    Luck += random.Next(1, 4);
                    break;
                case CombatClass.Wizard:
                    Health += random.Next(1, 16);
                    Power += random.Next(1, 6);
                    Luck += random.Next(1, 4);
                    break;
                case CombatClass.Rogue:
                    Health += random.Next(1, 16);
                    Power += random.Next(1, 4);
                    Luck += random.Next(3, 6);
                    break;
                default:
                    Health += 1;
                    Power += 1;
                    Luck += 1;
                    break;
            }

        }
        public void DisplayStats(bool showWithEquipment = false)
        {
            if (showWithEquipment)
            {
                Console.WriteLine(Name);
                Console.WriteLine(Level);
                Console.WriteLine(TotalHealth);
                Console.WriteLine(TotalPower);
                Console.WriteLine(TotalLuck);

            }
            else
            {
                Console.WriteLine(Name);
                Console.WriteLine(Level);
                Console.WriteLine(Health);
                Console.WriteLine(Power);
                Console.WriteLine(Luck);
            }

        }
        public void PowerLevel( int heroLevel)
        {
            for (int i = 0; i < heroLevel; i++)
            {
                LevelUp();
            }


        }
        public void AwakenHero(){
            Random random = new Random();
            int number = random.Next(1, 4);
            switch (number){
                case (int)CombatClass.Warrior:
                    CombatClass = CombatClass.Warrior;
                break;
                case (int)CombatClass.Wizard:
                CombatClass = CombatClass.Wizard;
                break;
                case (int)CombatClass.Rogue:
                CombatClass = CombatClass.Rogue;
                break;
            }
            int heroLevel = random.Next(8,13);
            PowerLevel(heroLevel);
        }

        public void CalculateTotals()
        {
        }
    }
}
