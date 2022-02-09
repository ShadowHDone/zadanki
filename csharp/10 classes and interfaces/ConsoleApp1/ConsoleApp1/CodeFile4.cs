
namespace Example4
{
    class Address
    {
        public string country = "";
        public string city = "";
        public string street = "";
        public Building build = new Building();
        public int postalCode;
    }

    class Building
    {
        public int number;
        public string literal = "";
        public int apartment;
    }

    class Runner
    {
        public static void Go()
        {

            Address address = new Address
            {
                country = "Russia",
                city = "Vladimir",
                street = "Puskina",
                postalCode = 600000,
                build = new Building
                {
                    number = 11,
                    apartment = 4,
                    literal = "a",
                }

            };

            //Address address2 = new Address();

            Console.WriteLine("Address:");
            Console.WriteLine($"{address.country}, {address.city}");
            Console.WriteLine($"{address.street} str., {address.build.number}{address.build.literal}, {address.build.apartment}");
            Console.WriteLine($"Postal: {address.postalCode}");
        }
    }
}
