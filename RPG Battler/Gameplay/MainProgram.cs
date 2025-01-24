using RPG_Battler.Character;

namespace RPG_Battler.Gameplay
{
    class MainProgram
    {
        static void Main()
        {
            Hero firstHero = new Hero();

            firstHero.DisplayStats();
            firstHero.AwakenHero();
            firstHero.LevelUp();
            Console.WriteLine(firstHero.CombatClass);

        }
    }
}
