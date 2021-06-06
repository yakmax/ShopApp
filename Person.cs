using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    class Person : Client
    //фамилия, дата заказа, сумма заказа, процент скидки
    {
        
        //public string orderdata { get; set; }       // дата заказа
        //public decimal ordersum { get; set; }       // сумма заказа
        //public int discount { get; set; }      //процент скидки

        //конструктор
        public Person (string name, string orderdata, decimal ordersum, int discount)
        {
            this.name = name;
            this.orderdata = orderdata;
            this.ordersum = ordersum;
            this.discount = discount;
        }



    }
}
