/**
 * Простейшее объединение нескольких свойств в один тип "Address"
 */
namespace Example
{
    class Address
    {
        /**
         * Всё это ниже -- значения по умолчанию, их можно заменить
         */
        public string country = "Russia";
        public string city = "Vladimir";
        public string street = "Puskina";
        public Building build = new Building();
        public int postalCode = 600000;
    }

    class Building
    {
        public int number = 11;
        public string literal = "а";
        public int apartment = 4;
    }

    class Runner
    {
        public static void Go()
        {

            Address address = new Address();

            //Address address2 = new Address();
            //address2.city = "Moscow";
            //address2.postalCode = 123001;

            Console.WriteLine("Address:");
            Console.WriteLine($"{address.country}, {address.city}");
            Console.WriteLine($"{address.street} str., {address.build.number}{address.build.literal}, {address.build.apartment}");
            Console.WriteLine($"Postal: {address.postalCode}");
        }
    }
}
