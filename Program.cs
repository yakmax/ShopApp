using System;

namespace ShopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Беляков","03.03.2020", 4100,10);
            //фамилия, дата заказа, сумма заказа, процент скидки
            Person p2 = new Person("Козлов", "05.05.2020", 1200, 75);
            Person p3 = new Person("Зорин", "07.07.2020", 7500, 50);
            
            Organization o1 = new Organization("Pepsi", "12.12.2021", 122000, 13, "Решальных Наталья");
            Organization o2 = new Organization("Coca-Cola", "12.12.2021", 136600, 11, "Свободный Алексей");
            Organization o3 = new Organization("Apple", "12.12.2021", 347000, 15, "Извозчиков Владимир");
            Organization o4 = new Organization("Amazone", "12.12.2021", 25333000, 14, "Старостин Андрей");
            //название, дата заказа, сумма заказа, процент скидки, контактное лицо

            //сортировка
            Client[] clients = new Client[] { p1, p2, p3, o1, o2, o3, o4 };
            Array.Sort(clients);
            
            //вывод на экран
            Client.Display(clients);

        }
    }
}
