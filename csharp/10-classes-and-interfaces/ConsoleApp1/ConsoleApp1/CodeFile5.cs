/**
 * Может произойти так, что нам понадобится более универсальный адрес с дополнительными
 * полями (например, это будет поле региона). Однако нет смысла описывать адрес полностью
 * заново, ведь всё в нём осталось прежним, только лишь добавилось одно поле. Добавление 
 * полей для нового класса на основе старого класса и называется "расширением" (extending).
 */
namespace Example
{
    class Address2 : Address
    {
        /**
         * Не смотря на то, что в этом классе описано
         * всего лишь одно поле, в объекте будут также
         * и поля родительского класса.
         */
        public string region = "Vladimirskaya obl.";
    }

    class Runner2
    {
        public static void Go()
        {

            Address2 address = new Address2();

            // Нам точно известно, что в Address2 есть все поля, которые есть в Address,
            // а значит можно использовать Address2 в объектах более низкого типа Address.
            // Однако тогда из него не получится достать новые поля, описанные в Address2.
            Address anotherAddress = new Address2();

            // Обратное правило не верно, в Address нет всех полей, которые есть в Address2,
            // а значит его нельзя так просто привести к этому формату.
            //Address2 strangeAddress = new Address(); // Ошибка

            // Однако нам может быть известно, что в переменной типа Address находится объект
            // типа Address2, что можно точно сказать об anotherAddress. Если разработчик
            // уверен, что в более низком типе точно есть более старший, то он может
            // поднять его уровень (преобразовать его тип) явно
            Address2 restoredAddress = (Address2)anotherAddress;

            Console.WriteLine("Address:");
            Console.WriteLine($"{address.country}");
            Console.WriteLine($"{address.region}, {address.city}"); // Теперь есть возможность вывести address.region
            Console.WriteLine($"{address.street} str., {address.build.number}{address.build.literal}, {address.build.apartment}");
            Console.WriteLine($"Postal: {address.postalCode}");
        }
    }
}
