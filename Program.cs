using System;
using static EventsTest.SubscriptionsClass;

namespace EventsTest
{
    public class Program
    {
        public enum ItemClass
        {
            Common,
            Uncommon,
            Rare,
            Epic,
            Legendary
        }

        // #1. Придумываем и создаём делегаты событий
        public delegate void DealDamage(int damage);
        public delegate void GotItem(ItemClass itemClass);

        static void Main(string[] args)
        {
            Hero kirito = new Hero()
            {
                Name = "Kirito",
                Damage = 30
            };
            Hero asuna = new Hero()
            {
                Name = "Asuna",
                Damage = 10
            };

            // #5.1. Подписываемся на эти события
            Subscribe(kirito, DamageDealingSubscription);
            Subscribe(asuna, DamageDealingSubscription);

            // #5.2. Или так, более стандартно
            kirito.ItemGetting += ItemGettingSubscription;
            asuna.ItemGetting += ItemGettingSubscription;

            // #6. Основной класс что-то делает, а мы наблюдаем,
            // т.к. события срабатывают сами благодаря #3
            
            kirito.GoingToArena();
            asuna.GoingToArena();

            kirito.GoingToDungeon("Blood river");
            asuna.GoingToDungeon("Blood river");

            // #7. Отписываемся при необходимости
            kirito.ItemGetting -= ItemGettingSubscription;
            asuna.ItemGetting -= ItemGettingSubscription;

            kirito.GoingToDungeon("Divine mountain");
            asuna.GoingToDungeon("Divine mountain");

            Console.ReadLine();
        }
    }
}