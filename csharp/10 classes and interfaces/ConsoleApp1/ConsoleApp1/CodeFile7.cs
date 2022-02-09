/** Пример и использованием интерфейсов
 */
namespace Example7
{
    class Address : Example5.Address, IPrintable
    {
        public Building build = new Building();
    }

    class Building : Example5.Building//, IPrintable
    {
        //public void Print()
        //{
        //    print();
        //}
    }

    //class User : IPrintable
    //{
    //    public string name = "";
    //    public string surname = "";
    //    public Address address = new Address();

    //    public void Print()
    //    {
    //        Console.WriteLine($"{name} {surname}");
    //    }
    //}

    interface IPrintable
    {
        void Print();
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

            //User user = new User
            //{
            //    name = "Вася",
            //    surname = "Петрович",
            //};

            Console.WriteLine("Address:");
            //address.Print();
            //address.build.Print();

            //user.Print();

            IPrintable[] toPrintArray = { address } //, address.build };

            for (int i = 0; i < toPrintArray.Length; i++)
            {
                toPrintArray[i].Print();
            }

        }
    }
}
