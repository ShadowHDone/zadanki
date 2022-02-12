/**
 * TODO:
 * 1. Дополнительно добавить описание и демонстрацию движения по дереву наследований
 * 2. Пересмотреть пример с типом building
 */
namespace Example
{
    class Address3 : Address2
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
            if (build is Building3)
            {
                // ((Example5.Building)build) позвоялет явно показать программе, что мы уверены,
                // что этот объект улучшенного класса.
                Building3 modernBuilding = (Building3)build;
                modernBuilding.print();
            }
            // Если build будет не типа Example5.Building (то есть будет типа Example4.Building),
            // то вывод информации о нём не произойдёт.
            Console.WriteLine($"Postal: {postalCode}");
        }
    }

    class Building3 : Building
    {
        // TODO: Исправить на Print, т.к. у нас из-за разных названий ошибки.
        public void print()
        {
            Console.WriteLine($"{number}{literal}, {apartment}");
        }
    }

    class Runner3
    {
        public static void Go()
        {
            Building3 build = new Building3
            {
                number = 723,
                apartment = 6,
                literal = "a",
            };

            Address3 address = new Address3
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
