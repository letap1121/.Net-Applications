using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory 
{
    //This example is based off an example in your book with modifications to the Event Signature.
    public delegate void PriceChangedEventHandler(decimal oldPrice, decimal newPrice);

    class Product
    {
        private string _name;
        private decimal _price;

        

        public event PriceChangedEventHandler PriceChanged;
       
        public Product()
        {
            _name = "";
            _price = 0;
        }

        public Product (string name)
        {
            _name = name;
            _price = 0;
        }

        public Product (string name, decimal price)
        {
            _name = name;
            _price = price;
        }

        public int Qty;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public decimal Price
        {
            get { return _price; }
            set
            {
                decimal oldPrice = _price;
                _price = value;
                if(PriceChanged!=null)
                {
                    PriceChanged(oldPrice, value);
                }
            }
        }

        public override string ToString()
        {
            return _name + " is priced at " + _price + ".";
        }
    }
}
