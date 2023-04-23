using System;

namespace EventsTest
{
    public class Hero
    {
        public string Name;
        public int Damage;

        // #2. Создаём сами события с типом этих делегатов
        public event Program.DealDamage? DamageDealing;
        public event Program.GotItem? ItemGetting;

        public void GoingToArena()
        {
            Console.WriteLine($"\n{Name} going to arena.");
            var dmg = Damage * 2;
            // #3. Вызваем эти события
            DamageDealing?.Invoke(dmg);

            var item = Program.ItemClass.Epic;
            ItemGetting?.Invoke(item);
        }

        public void GoingToDungeon(string dungeonName)
        {
            Console.WriteLine($"\n{Name} going to dungeon {dungeonName}...");
            var dmg = Damage;
            DamageDealing?.Invoke(dmg);

            var item = Program.ItemClass.Legendary;
            ItemGetting?.Invoke(item);
        }
    }
}