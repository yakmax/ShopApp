using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    class Organization : Client
    //название, дата заказа, сумма заказа, процент скидки, контактное лицо
    {
        //public string name { get; set; }        // фамилия 
        //public string orderdata { get; set; }       // дата заказа
        //public decimal ordersum { get; set; }       // сумма заказа
        //public int discount { get; set; }      //процент скидки
        public string contactperson { get; set; }      //контактное лицо

        //конструктор
        public Organization(string name, string orderdata, decimal ordersum, int discount, string contactperson)
        {
            this.name = name;
            this.orderdata = orderdata;
            this.ordersum = ordersum;
            this.discount = discount;
            this.contactperson = contactperson;
        }


    }
}
