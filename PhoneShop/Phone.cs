using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneShop
{

    //class to store info of a phone with a method to display a phone with a fixed layout. 
    class Phone
    {
        private readonly string brand;
        private readonly string type;
        private readonly string discription;
        private readonly int price;
        public Phone(string _brand, string _type, string _discription, int _price)
        {
            brand = _brand;
            type = _type;
            discription = _discription;
            price = _price;
        }

        public void ShowAllInfo()
        {
            Console.WriteLine(@"{0} {1} {2} {4}{4} {3}", brand, type, price, discription, Environment.NewLine);
        }
        public String GetName()
        {
            return brand + " " + type;           
        }
    }
}
