/** Пример и использованием интерфейсов
 */
namespace Example
{
    class Address4 : Address3, IPrintable
    {
        public Building4 build = new Building4();
    }

    class Building4 : Building3//, IPrintable
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

    class Runner4
    {
        public static void Go()
        {

            Address4 address = new Address4
            {
                country = "Russia",
                city = "Vladimir",
                street = "Puskina",
                postalCode = 600000,
                build = new Building4
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

            IPrintable[] toPrintArray = { address }; //, address.build };

            for (int i = 0; i < toPrintArray.Length; i++)
            {
                toPrintArray[i].Print();
            }

        }
    }
}
