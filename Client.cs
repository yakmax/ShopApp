using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    abstract class Client : IComparable
    {
        public string orderdata { get; set; }       // дата заказа
        public decimal ordersum { get; set; }       // сумма заказа
        public int discount { get; set; }      //процент скидки
        public string name { get; set; }        // фамилия 

        //функция, позволяющая вывести на экран информацию о клиентах интернет-магазина
        public static void Display(Client[] cc)
        {
            foreach (Client c in cc)
            {
                Console.WriteLine($"{c.name} - {c.ordersum}");
            }
        }

        //реализация метода для сортировки покупателей по сумме заказов
        public int CompareTo(object o)
        {
            Client c = o as Client;
            if (c != null)
                return this.ordersum.CompareTo(c.ordersum);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }
    }
}
