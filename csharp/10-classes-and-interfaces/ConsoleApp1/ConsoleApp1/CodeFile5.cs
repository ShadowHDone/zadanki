/**
 * TODO:
 * 1. Добавить прослойку между Example5 и Example4 с более простым наследованием, без методов
 * 2. Дополнительно добавить описание и демонстрацию движения по дереву наследований
 */
namespace Example5
{
    class Address : Example4.Address
    {
        public void Print()
        {
            Console.WriteLine($"{country}, {city}");
            Console.Write($"{street} str., ");
            // Текущий Address наследует информацию из Example4.Address, который в свою очередь
            // содержит в себе Example4.Building (то есть использует объект класса из прошлого примера)
            // У Example4.Building нет метода print(), так что его вызвать не получится.
            // Однако класс Example5.Building (это класс в этом файле, т.к. у файла неймспейс Example5)
            // такой метод имеет, а ещё является развитием старого Example4.Building.
            // Благодаря этому в старую переменную build можно вписать новый, более крутой класс.
            // Однако надо убедиться, что build является более крутым, это тут и выполняется:
            if (build is Example5.Building)
            {
                // ((Example5.Building)build) позвоялет явно показать программе, что мы уверены,
                // что этот объект улучшенного класса.
                Building modernBuilding = (Example5.Building)build;
                modernBuilding.print();
            }
            // Если build будет не типа Example5.Building (то есть будет типа Example4.Building),
            // то вывод информации о нём не произойдёт.
            Console.WriteLine($"Postal: {postalCode}");
        }
    }

    class Building : Example4.Building
    {
        // TODO: Исправить на Print, т.к. у нас из-за разных названий ошибки.
        public void print()
        {
            Console.WriteLine($"{number}{literal}, {apartment}");
        }
    }

    class Runner
    {
        public static void Go()
        {
            Building build = new Building
            {
                number = 723,
                apartment = 6,
                literal = "a",
            };

            Address address = new Address
            {
                country = "Russia",
                city = "Vladimir",
                street = "Puskina",
                postalCode = 600000,
                build = build

            };

            Console.WriteLine("Address:");
            address.Print();

        }
    }
}
