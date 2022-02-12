/**
 * Это пример реализации полиморфизма силами классов,
 * как это происходило бы без интерфейсов
 */
namespace Example
{
    class ThisClassCanToPrint
    {
        public virtual void Print()
        {
            Console.WriteLine($"I can to print, bun I have no any data");
        }
    }

    class SuperAddress : ThisClassCanToPrint
    {
        override public void Print()
        {
            Console.WriteLine($"This is an Address");
        }
    }

    class SuperBuilding : ThisClassCanToPrint
    {
        override public void Print()
        {
            Console.WriteLine($"This is a Build");
        }
    }

    class Runner4
    {
        public static void Go()
        {

            SuperAddress address = new SuperAddress();
            SuperBuilding build = new SuperBuilding();

            address.Print();
            build.Print();

        }
    }
}
