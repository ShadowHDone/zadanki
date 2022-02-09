/**
 * Это пример реализации полиморфизма силами классов,
 * как это происходило бы без интерфейсов
 */
namespace Example6
{
    class SuperAddress : ThisClassCanToPrint
    {
        override public void Print()
        {
            Console.WriteLine($"This is an Address");
        }
    }

    class Building : ThisClassCanToPrint
    {
        override public void Print()
        {
            Console.WriteLine($"This is a Build");
        }
    }

    class ThisClassCanToPrint
    {
        public virtual void Print()
        {
            Console.WriteLine($"I can to print, bun I have no any data");
        }
    }

    class Runner
    {
        public static void Go()
        {

            SuperAddress address = new SuperAddress();
            Building build = new Building();

            address.Print();
            build.Print();

        }
    }
}
