using System;

namespace EventsTest
{
    public static class SubscriptionsClass
    {
        public static void Subscribe(Hero h, Program.DealDamage d)
        {
            h.DamageDealing += d;
        }

        // #4. Придумываем и пишем обработчики событий
        public static void ItemGettingSubscription(Program.ItemClass itemClass)
        {
            Console.WriteLine("...ItemGettingSubscription");
            if (itemClass == Program.ItemClass.Legendary)
                Console.WriteLine(">>> New achievement: legendary item!");
        }

        public static void DamageDealingSubscription(int damage)
        {
            Console.WriteLine("...DamageDealingSubscription");
            if (damage > 30)
                Console.WriteLine(">>> New achievement: big damage!");
        }
    }
}