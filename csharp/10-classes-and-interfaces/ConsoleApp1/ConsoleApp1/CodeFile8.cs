/** Пример и использованием интерфейсов
 */
namespace Example
{
    class Address5 : Address3, IPrintable
    {
        /**
         * Увы, но с изменением типов полей у потомков в ООП есть определённые ограничения,
         * которые иногда становятся недостатками, как тут. Код строкой ниже скомпилируется,
         * но не рекомендуется
         */
        public Building5 build = new Building5();
    }

    class Building5 : Building3//, IPrintable
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

    class Runner5
    {
        public static void Go()
        {

            Address5 address = new Address5();

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
