using RPG_Battler.Character;

namespace RPG_Battler.Gameplay
{
    class MainProgram
    {
        static void Main()
        {
            Hero valleyHero = new Hero();

            Console.WriteLine(valleyHero.CombatClass);
            valleyHero.DisplayStats();

            valleyHero.AwakenHero();
            valleyHero.DisplayStats();
            Console.WriteLine(valleyHero.CombatClass);

            Monster slime = new Monster();
            slime.DisplayStats();

        }
    }
}
